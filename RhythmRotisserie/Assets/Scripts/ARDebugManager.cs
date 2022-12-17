using System;
using System.Linq;
using TMPro;
using UnityEngine;

public class ARDebugManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI debugAreaText = null;

    [SerializeField]
    private bool enableDebug = false;

    [SerializeField]
    private int maxLines = 8;
    private static ARDebugManager m_instance;
    public static ARDebugManager Instance {
        get
        {
            return m_instance;
        }
    }
    private void Awake()
    {
        m_instance = this;
    }
    void OnEnable()
    {
        debugAreaText.enabled = enableDebug;
        enabled = enableDebug;
    }

    public void LogInfo(string message)
    {
        ClearLines();
        debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M HH:mm:ss")}: <color=\"white\">{message}</color>\n";
    }
    public void LogInfoSimple(string message)
    {
        ClearLines();
        debugAreaText.text += $"{message}</color>\n";
    }
    public void LogError(string message)
    {
        ClearLines();
        debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M HH:mm:ss")}: <color=\"red\">{message}</color>\n";
    }

    public void LogWarning(string message)
    {
        ClearLines();
        debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M HH:mm:ss")}: <color=\"yellow\">{message}</color>\n";
    }

    private void ClearLines()
    {
        if (debugAreaText.text.Split('\n').Count() >= maxLines)
        {
            debugAreaText.text = string.Empty;
        }
    }
}