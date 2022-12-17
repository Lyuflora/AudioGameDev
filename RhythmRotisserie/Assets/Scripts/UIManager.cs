using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static public UIManager m_Instance;

    public TextMeshProUGUI startMessage;
    public TextMeshProUGUI timeDiff;

    [Header("Moving Hand")]
    public Image hand;
    public Image handSecond;
    public Image filter;
    private RectTransform trans_Hand;
    private RectTransform trans_SmoothHand;
    public float speed_SmoothHand;
    [SerializeField]
    private Vector3 moveDirection;

    private IEnumerator handMoveCoroutine;
    private WaitForSeconds delay;
    private WaitForSeconds delta;
    private WaitForSeconds startDelayWait;

    public bool readyToPlay = false;
    public bool readyToMove = false;
    public float beatTime = 2f/4;
    public float deltaTime;

    public Transform beatParent;

    [Header("Color Preset")]
    public Color32 heatColor = new Color32(255, 200, 100, 255);
    public Color32 normalColor = new Color32(125, 120, 110, 255);

    Color32 handColor;
    Color32 handColor_Second;

    public Image success;
    public Image miss;

    public Animator vibration;
    private void Awake()
    {
        m_Instance = this;
        trans_SmoothHand = handSecond.GetComponent<RectTransform>();
        moveDirection = Vector3.right;
        speed_SmoothHand = 100f / (beatTime);
    }
    void Start()
    {
        // Initialize
        handMoveCoroutine = PlayBar();

        readyToPlay = false;
        readyToMove = false;
        success.enabled = false;
        miss.enabled = false;

        deltaTime = (beatTime) / 2;
        delay = new WaitForSeconds(beatTime);
        delta = new WaitForSeconds(deltaTime);
        startDelayWait = new WaitForSeconds(BeatManager.m_Instance.startDelay);

        handColor = hand.color;
        handColor_Second = handSecond.color;

        if (filter)
        {
            filter.enabled = false;
        }
    }
    void Update()
    {
        // Move Hand Discrete
        if (readyToPlay)
        {
            StartCoroutine(handMoveCoroutine);
        }
    }
    void FixedUpdate()
    {
        // Move Hand (Continuous)
        if (readyToMove)
        {
            //trans_SmoothHand.position += moveDirection * Time.deltaTime * speed_SmoothHand;
            if (trans_SmoothHand.anchoredPosition.x >= 850)
            {
                HandSecondReset();
            }
        }
    }

    public float GetHandPosX(int handIndex)
    {
        if (handIndex == 0)
        {
            return hand.GetComponent<RectTransform>().anchoredPosition.x;
        }
        else
        {
            return handSecond.GetComponent<RectTransform>().anchoredPosition.x;
        }
    }

    public void BarStart()
    {
        readyToPlay = true;
        readyToMove = true;
    }


    private IEnumerator PlayBar()
    {
        ReadBar();
        readyToPlay = false;

        for(int i = 0; i < 8; i++)
        {
            HandMoveDiscrete(i, hand.GetComponent<RectTransform>());
            yield return delta;
            HandMoveDiscrete(i, handSecond.GetComponent<RectTransform>());
            yield return delta;

        }
        
        HandReset();
        BeatManager.m_Instance.NextBar();

        int index = BeatManager.m_Instance.GetCurrentBar();
        if (BeatManager.m_Instance.NeedWait(index))
        {
            yield return startDelayWait;
        }
       
        StartCoroutine(PlayBar());
    }

    public void ReadBar()
    {
        // go through children
        int children = beatParent.childCount;
        for (int i = 0; i < children; ++i)
        {
            SetNormalColor(beatParent.GetChild(i).gameObject.GetComponent<Image>());
        }

        // get indices from beatmanager
        if (!BeatManager.m_Instance.CheckBeatUnderLimit())
        {
            return;
        }
        List<Beat> beatList = BeatManager.m_Instance.GetCurrentBeatList();

        for (int i = 0; i < beatList.Count; ++i)
        {
            Debug.Log("BeatList: " + i);
            Beat beat = beatList[i];
            if (beat.isKey)
            {
                SetHeatColor(beatParent.GetChild(i).gameObject.GetComponent<Image>());
            }
        }
            

    }

    public void SetNormalColor(Image img)
    {
        img.color = normalColor;
    }
    public void SetHeatColor(Image img)
    {
        img.color = heatColor;
    }
    // called every beat
    public void HandMoveDiscrete(int index, RectTransform handTrans)
    {
        
        handTrans.anchoredPosition = new Vector2(handTrans.anchoredPosition.x + 100, handTrans.anchoredPosition.y);
        BeatManager.m_Instance.CheckHeatBeat(index);
    }
    public void HandMoveContinuous()
    {

    }

    public void HandReset()
    {
        readyToPlay = true;
        RectTransform handTrans = hand.GetComponent<RectTransform>();
        handTrans.anchoredPosition = new Vector2(-50, handTrans.anchoredPosition.y);

    }
    public void HandSecondReset()
    {
        RectTransform handSmoothTrans = handSecond.GetComponent<RectTransform>();
        handSmoothTrans.anchoredPosition = new Vector2(50, handSmoothTrans.anchoredPosition.y);

    }
    public void HandStop()
    {
        StopCoroutine(handMoveCoroutine);
        hand.enabled = false;
    }
    public void ShowGrade(bool isSuccess)
    {
        if (isSuccess)
        {
            success.enabled = true;
            miss.enabled = false ;
        }
        else
        {
            success.enabled=false;
            miss.enabled=true ;

        }
    }

    public void SwitchStartUI()
    {
        startMessage.enabled = false;

    }
    public void ShowVibrationUI()
    {
        vibration.SetTrigger("Vibrate");
    }
    public void SwitchFilter()
    {
        if (filter)
        {
            filter.enabled = !filter.enabled;
        }
    }
    public void SwitchHelpMode()
    {
        Color32 tempHandColor = handColor;
        Color32 tempHandColor_Second=handColor_Second;

        if (hand.color.a != 0)
        {
            tempHandColor.a = 0;
            hand.color= tempHandColor;

            tempHandColor_Second.a = 0;
            handSecond.color = tempHandColor_Second;
        }
        else
        {
            hand.color = handColor;
            handSecond.color = handColor_Second;
        }
    }
}
