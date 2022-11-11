using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    virtual public void Hover()
    {
        Debug.Log("Listen sound1 "+name);
    }
    
    virtual public void Focus()
    {
        Debug.Log("Listen sound2" + name);
    }
}
