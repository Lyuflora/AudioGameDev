using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI debugAreaText = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPoint = Camera.main.ScreenToWorldPoint(touch.position);
            touchPoint.z = 0;
            transform.position = touchPoint;
        }

    }
}
