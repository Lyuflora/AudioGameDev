using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpaceManager : MonoBehaviour
{
    [SerializeField]
    private ARAnchorManager anchorManager = null;

    [SerializeField]
    private TextMeshProUGUI objMessageText = null;
    [SerializeField]
    private TextMeshProUGUI camMessageText = null;
    [SerializeField]
    private TextMeshProUGUI screenMessageText = null;

    public GameObject cube;

    private List<ARAnchor> anchors = new List<ARAnchor>();
    private static SpaceManager m_instance;
    public static SpaceManager Instance
    {
        get
        {
            return m_instance;
        }
    }
    private void Start()
    {
        ARDebugManager.Instance.LogInfo("Start");
    }

    private void Update()
    {
        if(cube != null)
        {
            objMessageText.text = "Cube: " + cube.transform.position.ToString();
            camMessageText.text = "Cam: " + Camera.main.transform.position.ToString();
            Debug.DrawLine(Camera.main.transform.position, cube.transform.position, Color.white, 2.5f);
        }

        GetOrientation();
    }

    public void ReloadScene()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void GetOrientation()
    {

        float rotZ = 0;
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                rotZ = 90;
                break;
            case ScreenOrientation.LandscapeLeft:
                rotZ = 180;
                break;
            case ScreenOrientation.LandscapeRight:
                rotZ = 0;
                break;
            case ScreenOrientation.PortraitUpsideDown:
                rotZ = -90;
                break;
        }
        Quaternion rotation = Quaternion.Euler(0, 0, rotZ);
        Matrix4x4 m = Matrix4x4.Rotate(rotation);
        screenMessageText.text = Input.deviceOrientation.ToString();
    }
}
