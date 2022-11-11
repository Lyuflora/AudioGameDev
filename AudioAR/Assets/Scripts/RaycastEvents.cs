using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastEvents : MonoBehaviour
{
    private RayCaster ray;
    public bool castState;
    private float rayHitStart = 0f;
    [SerializeField]
    Transform origin;   // Camera.main

    public bool isHearing = false;

    [SerializeField]
    int layer;
    void Start()
    {
        ray = new RayCaster();
        ray.OnRayEnter += Ray_OnEnter;
        ray.OnRayStay += Ray_OnStay;
        ray.OnRayExit += Ray_OnExit;
        layer = ray.m_Layer = RayCaster.GetLayerMask("Interactable");  // OPTIONAL
        ray.m_StartTransform = origin;
        ray.m_Direction = Camera.main.transform.forward;
        ray.m_RayLength = 10f;
    }

    void LateUpdate()
    {
        castState = ray.CastRay();
        // ray.CastLine();  // If you want to use a Line Caster instead.
    }


    void Ray_OnEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Interactable>()) {
            rayHitStart = Time.time;
            Debug.Log("Hover Interactable");
        }
    }

    void Ray_OnStay(Collider collider)
    {

        if (collider.gameObject.GetComponent<Interactable>())
        {
            if (Time.time - rayHitStart > 3f && isHearing == false)
            {
                // Object has been hit for five seconds - do something!
                Debug.Log("Hover Long");
                isHearing = true;
            }
        }

    }

    void Ray_OnExit(Collider collider)
    {
        if (collider.tag == "Target")
        {
            rayHitStart = 0f;
            isHearing = false;
        }
    }
}
