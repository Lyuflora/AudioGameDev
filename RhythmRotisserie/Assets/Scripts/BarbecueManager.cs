using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using bTimer = TurnTheGameOn.Timer.Timer;

// Game Manager
public class BarbecueManager : MonoBehaviour
{
    public static BarbecueManager m_instance;

    FMOD.Studio.Bus MasterBus;

    public Meat meat;
    public GameObject bgObj;

    [SerializeField]
    private bool facingUp = true;

    private void Awake()
    {
        m_instance = this;
    }
    private void Start()
    {
        MasterBus = FMODUnity.RuntimeManager.GetBus("bus:/");
    }
    public void RestartGame()
    {
        MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void BackStartPage()
    {
        MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);

        SceneManager.LoadScene(0);
    }
    public void LoadEndScene(bool isSuccess)
    {
        if (isSuccess)
        {
            LoadSuccessScene();
        }
        else
        {
            LoadFailScene();
        }
    }
    public void LoadSuccessScene()
    {
        SceneManager.LoadScene("Success");
    }
    public void LoadFailScene()
    {
        SceneManager.LoadScene("Fail");
    }
    // Phone
    public void ChangeBackgroundColor(DeviceOrientation direction)
    {
        if (direction== DeviceOrientation.FaceUp)
        {
            bgObj.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
            facingUp= false;
        }
        else
        {
            bgObj.GetComponent<Renderer>().material.color = new Color(205, 0, 102);
            facingUp = true;
        }
    }

    public void ChangeBackgroundColor(bool isFacingUp)
    {
        if (isFacingUp)
        {
            bgObj.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
            facingUp = false;
        }
        else
        {
            bgObj.GetComponent<Renderer>().material.color = new Color(205, 0, 102);
            facingUp = true;
        }
    }
}
