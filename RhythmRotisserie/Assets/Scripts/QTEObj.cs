using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RDG;

public class QTEObj : MonoBehaviour
{

    public Image ring;
    public Image center;

    public float fillAmount = 0;

    [Range(0.0f, 10f)]
    public float timeToClear = 1f;
    public float lifetime = 3f;



    // During QTE, wait for the player's input
    public bool m_WaitForAction = false;

    private void Start()
    {
        m_WaitForAction = false;
    }

    private void FixedUpdate()
    {

        // Automatically decrease the amount
        float deltaAmount = 1f / timeToClear * Time.deltaTime;
        if (ring.fillAmount > Mathf.Abs(deltaAmount))
        {
            ring.fillAmount -= Mathf.Abs(deltaAmount);
        }
        var tempColor = ring.color;
        if (ring.fillAmount <= Mathf.Abs(deltaAmount))
        {
            // hide when time pass
            ring.fillAmount = 0f;
            //tempColor.a = 0f;
            //ring.color = tempColor;
            //center.color = tempColor;

            m_WaitForAction = false;
            
        }
        else
        {
            tempColor.a = 1f;
        }
    }

    IEnumerable DeleteQTEObj()
    {
        yield return new WaitForSecondsRealtime(lifetime-timeToClear);
    }

    public void SetFillAmount()
    {

        ring.fillAmount = fillAmount;

    }
    public void ChangeColor(int index)
    {
        Debug.Log(ring.fillAmount);
        float delta = Mathf.Abs(1-(0.125f * (index + 1))- ring.fillAmount);
        UIManager.m_Instance.timeDiff.text = string.Format("{0} and fill amount {1}", 0.125f * (index + 1), ring.fillAmount);
        if (delta < 0.15f)
        {
            center.color = Color.yellow;
        }
        else
        {
            center.color = Color.red;
        }
        //StartCoroutine(FadeImage(true));

    }

    IEnumerator FadeImage(bool fadeAway)
    {
        var tempColor = center.color;
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 0.7f; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                center.color = new Color(tempColor.r, tempColor.g, tempColor.b, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                center.color = new Color(tempColor.r, tempColor.g, tempColor.b, i);
                yield return null;
            }
        }
    }

    public void ResetQTE()
    {
        fillAmount = 1f;
        SetFillAmount();
        Vibration.Vibrate(100, -1, false);
        m_WaitForAction = true;
    }

}
