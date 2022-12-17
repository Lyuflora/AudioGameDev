using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.Assertions;

using bTimerPro = TurnTheGameOn.Timer.TimerPro;
using bTimerEvent = TurnTheGameOn.Timer.TimeEvent;


// give Test Runner access to private variables and methods
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("JsonReaderTest")]

[Serializable]
public class JsonBeat
{
    public string Name;
    public float Time;
    public string EventListener;

}

[System.Serializable]
public class JsonBeatList
{
    // jsonLessonList is case sensitive and must match the string "jsonLessonList" in the JSON.
    public JsonBeat[] jsonBeatList;
}



public class JsonReader : MonoBehaviour
{
    //=================== Set from Unity editor =======================
    // file to read lessons from
    public TextAsset jsonFile;

    //=================== MonoBehavior interface =======================
    void Start()
    {
        beatList = LoadBeatFromFile();
    }

    //======================= public API =================================


    // create one instance of the TrialController for the app
    private static JsonReader jsonReader;

    // link to timer
    public bTimerPro myTimerPro;


    public static JsonReader Instance()
    {
        if (!jsonReader)
        {
            jsonReader = FindObjectOfType(typeof(JsonReader)) as JsonReader;

            if (!jsonReader)
            {
                Debug.LogError("JsonReader inactive or missing from unity scene.");
            }
        }

        return jsonReader;
    }

    //============= internal structures and methods ======================

    // Make result of json read available to test runner
    internal JsonBeatList beatList;


    public JsonBeatList LoadBeatFromFile()
    {
        Assert.IsNotNull(jsonFile);

        JsonBeatList testBeatList = JsonUtility.FromJson<JsonBeatList>(jsonFile.text);

        foreach (JsonBeat beat in testBeatList.jsonBeatList)
        {
            // Debug.Log("Found beat: " + beat.Name);

            // load beat from json to timerpro, 
            // need to call function in qtesystem

            AddNewEventFromJson(beat);
        }

        return testBeatList;
    }
    public void AddNewEventFromJson(JsonBeat beat)
    {
        // new event
        bTimerEvent newTimeEvent = new bTimerEvent();

        newTimeEvent.eventTime = beat.Time;
        newTimeEvent.eventName = beat.Name;
        newTimeEvent.timeEvent = new UnityEvent();

        if(beat.EventListener== "TestBeat")
        {
            newTimeEvent.timeEvent.AddListener(TestBeat);
        }
        else if(beat.EventListener == "TestPattern")
        {
            newTimeEvent.timeEvent.AddListener(TestPattern);
        }

        newTimeEvent.wasTriggered = false;

        myTimerPro.timeEvents.Add(newTimeEvent);
    }

    void TestBeat()
    {
        //QTESystem.m_Instance.GeneratQTEObj();
        Debug.Log("Beat");
    }

    void TestPattern()
    {
        //QTESystem.m_Instance.GeneratQTEObjs();
        Debug.Log("Pattern");
    }
}
