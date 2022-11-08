using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public Material materialDefault;
    public Material materialHighlight;
    public void ChangeMat(bool hitPlane)
    {
        this.GetComponent<MeshRenderer>().material = hitPlane ? materialHighlight : materialDefault;
    }
    private void Start()
    {
        
    }
}
