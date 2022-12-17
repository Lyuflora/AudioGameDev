using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : Interactable
{

    public override void Hover()
    {
        base.Hover();
    }

    public override void Focus()
    {
        base.Focus();
        Debug.Log("This is target");
    }
}
