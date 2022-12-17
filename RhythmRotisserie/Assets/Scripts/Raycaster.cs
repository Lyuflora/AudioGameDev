using System;
using System.Collections;
using UnityEngine;

public class RayCaster
{

    public Transform m_StartTransform;
    public Vector3 m_EndPosition;
    public Vector3 m_Direction;
    public float m_RayLength;
    public int m_Layer;

    public event Action<Collider> OnRayEnter;
    public event Action<Collider> OnRayStay;
    public event Action<Collider> OnRayExit;

    Collider previous;
    RaycastHit hit = new RaycastHit();

    public RayCaster()
    {

    }

    public bool CastRay()
    {
        Physics.Raycast(m_StartTransform.position, m_Direction, out hit, m_RayLength, m_Layer);
        ProcessCollision(hit.collider);
        return hit.collider != null ? true : false;
    }

    public bool CastLine()
    {
        int layerMask = 1 << m_Layer;
        Physics.Linecast(m_StartTransform.position, m_EndPosition, out hit);
        ProcessCollision(hit.collider);
        return hit.collider != null ? true : false;
    }

    private void ProcessCollision(Collider current)
    {
        // No collision this frame.
        if (current == null)
        {
            // But there was an object hit last frame.
            if (previous != null)
            {
                DoEvent(OnRayExit, previous);
            }
        }

        // The object is the same as last frame.
        else if (previous == current)
        {
            DoEvent(OnRayStay, current);
        }

        // The object is different than last frame.
        else if (previous != null)
        {
            DoEvent(OnRayExit, previous);
            DoEvent(OnRayEnter, current);
        }

        // There was no object hit last frame.
        else
        {
            DoEvent(OnRayEnter, current);
        }

        // Remember this object for comparing with next frame.
        previous = current;
    }

    private void DoEvent(Action<Collider> action, Collider collider)
    {
        if (action != null)
        {
            action(collider);
        }
    }

    public static int GetLayerMask(string layerName, int existingMask = 0)
    {
        int layer = LayerMask.NameToLayer(layerName);
        return existingMask | (1 << layer);
    }

}
