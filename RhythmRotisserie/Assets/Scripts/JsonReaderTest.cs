using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.TestTools;

using bTimerPro = TurnTheGameOn.Timer.TimerPro;
using bTimerEvent = TurnTheGameOn.Timer.TimeEvent;

namespace Tests
{
    public class JsonReaderTest:MonoBehaviour
    {
        public static JsonReaderTest m_Instance;

        public void Awake()
        {
            m_Instance = this;
        }
        // create instance for test
        JsonReader jsonReader;

        //JsonLessonList jsonLessonList;

        public void Setup()
        {
            jsonReader = GetComponent<JsonReader>();
            jsonReader.jsonFile = Resources.Load("lesson-test") as TextAsset;
        }


        private void Start()
        {
            Setup();
           
        }



        private void Update()
        {

        }


        public void Teardown()
        {
            Object.Destroy(jsonReader);
        }

        // Verify class exists
        public void JsonReaderClassExists()
        {
            ARDebugManager.Instance.LogInfo(jsonReader.ToString());
            ARDebugManager.Instance.LogInfo(jsonReader.jsonFile.ToString());
        }

        public IEnumerator TestStart()
        {
            ARDebugManager.Instance.LogInfo("PASS, ignore stack trace");

            yield return null;
        }

        public void TestFileParsesOkTest()
        {
            JsonBeatList testBeatList = jsonReader.LoadBeatFromFile();

            // NullReferenceException here is often caused by an error in the test file itself,
            // check that field names match the structure
            ARDebugManager.Instance.LogInfo(testBeatList.ToString());
        }



    }
}