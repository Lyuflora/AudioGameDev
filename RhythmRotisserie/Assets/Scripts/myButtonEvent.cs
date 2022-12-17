using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class myButtonEvent : Button
{
    // Button is Pressed
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        Debug.Log("Button pressed");
        //gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Pressed";
    }

    // Button is released
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        //gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "Released";

    }
}