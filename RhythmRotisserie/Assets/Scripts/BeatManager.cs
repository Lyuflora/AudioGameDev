using RDG;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Emitter = FMODUnity.StudioEventEmitter;

[Serializable]
public class Beat
{
    public bool isKey;
    public bool triggered;
}
[Serializable]
public class Bar
{
    public string name;
    public float length;    // (0.2delay)2.2, 2
    public List<Beat> beatList;  // 0 to 7, true or false
    public int correctNum = 0;
    public float correctRatio;  // 0 to 1
    public bool startWait = false;
}

public enum BeatState
{
    Beating,
    Disabled,
}

public class BeatManager : MonoBehaviour
{
    public static BeatManager m_Instance;

    [Header("Bars")]
    public List<Bar> m_BarList = new List<Bar>();

    [Header("FMOD")]
    public Emitter bbqEmitter;
    public Emitter mainMusicEmitter;
    public Emitter correctEmitter;
    public Emitter warningEmitter;

    public BeatState beatState;
    public float startDelay = 2f;
    private int currentBar = 0;
    public int maxBar = 4;

    public bool CheckBeatUnderLimit()
    {
        if (currentBar < maxBar)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Beat> GetCurrentBeatList()
    {
        return m_BarList[currentBar].beatList;
    }

    private void Awake()
    {
        m_Instance = this;
    }
    private void Start()
    {
        currentBar = 0;
        InitBarList();
    }

    public void InitBarList()
    {
        for(int i = 0; i < m_BarList.Count; i++)
        {
            for(int j = 0; j < m_BarList[i].beatList.Count; j++)
            {
                m_BarList[i].beatList[j].triggered = false;
            }
        }
    }

    public void StartBeating()
    {
        beatState = BeatState.Beating;
        UIManager.m_Instance.BarStart();
    }
    public void PlayPositive()
    {
        correctEmitter.Play();
    }

    public void PlayWarning()
    {
        warningEmitter.Play();
    }

    public void PlayStartSound()
    {
        mainMusicEmitter.Play();
    }

    public void PlayBar()
    {
        

    }
    public void NextBar()
    {
        currentBar++;
        BarbecueManager.m_instance.meat.MeatReset();
        if (currentBar >= maxBar)
        {
            beatState = BeatState.Disabled;
            UIManager.m_Instance.HandStop();
            Debug.Log("Stop beating" + currentBar);
            // Go to grading scene
            BarbecueManager.m_instance.LoadEndScene(GetFinalGrade());
        }

    }
    public int GetCurrentBar()
    {
        return currentBar;
    }
    public bool NeedWait(int index)
    {
        return m_BarList[index].startWait;
    }
    public bool GetFinalGrade()
    {
        // get total key and triggered key num
        float ratio = 0;
        int totalKey = 0;
        int triggeredKey = 0;
        for(int i = 0; i < m_BarList.Count; i++)
        {
            for(int j=0; j < m_BarList[i].beatList.Count; j++)
            {
                Beat beat = m_BarList[i].beatList[j];
                if (beat.isKey)
                {
                    totalKey++;
                    if (beat.triggered)
                    {
                        triggeredKey++;
                    }
                }
            }
        }

        if (totalKey > 0)
        {
            ratio = (float)triggeredKey / (float)totalKey;
            Debug.Log("Correct Ratio: " + triggeredKey + ratio);
            return ratio > 0.6;
        }
        else
        {
            return false;
        }
    }
    public void CheckHeatBeat(int index)
    {
        if (beatState == BeatState.Disabled) return;
        // play the key beat sfx one beat earlier
        if (index == 6 && m_BarList[currentBar].beatList[7].isKey)
        {
            bbqEmitter.Play();

        }
        else if (index == 7)
        {
            return;
        }
        else if (m_BarList[currentBar].beatList[index+1].isKey)
        {
            bbqEmitter.Play();

        }
        else
        {

        }
    }
    public void CheckHitBeat()
    {
        BarbecueManager.m_instance.meat.ShowSurface(true);
        // if the hand is not at the hitting slot
        // fail

        float handPos_0 = UIManager.m_Instance.GetHandPosX(0);
        float handPos_1 = UIManager.m_Instance.GetHandPosX(1);

        Debug.Log("hand position:" + handPos_0);


        int currentBeat_min = (int)(handPos_0 - 50)/100;
        int currentBeat_max = (int)(handPos_1 - 50)/100;
        // go through all the beat in current bar
        // if current beat matches any beat in the list
        // mark as success
        if(currentBeat_max<=4)
        if (m_BarList[currentBar].beatList[currentBeat_max+3].isKey)
        {
            Vibration.Vibrate(100, -1, false);
            UIManager.m_Instance.ShowVibrationUI();
        }

        int index=Mathf.Max(currentBeat_min, currentBeat_max);
        if (m_BarList[currentBar].beatList[index].isKey)
        {
            m_BarList[currentBar].beatList[index].triggered = true;

            Vibration.Vibrate(200, -1, false);
            Debug.Log("Result: Perfect at " + currentBar + " Bar " + index);
            //UIManager.m_Instance.ShowGrade(true);
            PlayPositive(); 
            BarbecueManager.m_instance.meat.MeatCooked();
        }
        else
        {
            Vibration.Vibrate(100, 100, false);
            Debug.Log("Result: Miss at " + currentBar + " Bar " + currentBeat_max);
            //UIManager.m_Instance.ShowGrade(false);
            PlayWarning();
            BarbecueManager.m_instance.meat.MeatOvercooked();
            return;
        }

        //for(int i=0; i< m_BarList[currentBar].beatList.Count; i++)
        //{
        //    if(m_BarList[currentBar].beatList[i] == currentBeat)
        //    {
        //        m_BarList[currentBar].correctNum++;
        //        Vibration.Vibrate(100, -1, false);
        //        Debug.Log("Result: Perfect at " + currentBar + " Bar " + currentBeat);
        //        UIManager.m_Instance.ShowGrade(true);
        //    }
        //    else
        //    {
        //        Vibration.Vibrate(100, -1, false);
        //        Debug.Log("Result: Miss at " + currentBar+" Bar "+currentBeat);
        //        UIManager.m_Instance.ShowGrade(false);
        //        continue;
        //    }
        //}
    }
}
