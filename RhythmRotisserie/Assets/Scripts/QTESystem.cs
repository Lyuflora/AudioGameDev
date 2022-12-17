using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QTESystem : MonoBehaviour
{
    static public QTESystem m_Instance;

    public float respawnTerm = 3f;
    public GameObject qtePrefabs;
    public GameObject qteParent;

    public GameObject circlePrefabs;
    public GameObject scorePrefabs;

    public float timeScale = 1f;

    public QTEObj qte;

    int onByOnNum = 0;

    public int currentIndex = 0;

    private void Awake()
    {
        m_Instance = this;
    }

    private void Start()
    {
        qte.ResetQTE();
        //InvokeRepeating(nameof(ResetQTE), 0f, respawnTerm);
        //GeneratQTEObjs();
    }
    
    public void GenerateCircle()
    {
        GameObject new_qte = Instantiate(circlePrefabs,
            new Vector3(1 * 2.0f, 0, 0), Quaternion.identity);
        new_qte.transform.parent = qteParent.transform;
        new_qte.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // normal speed
    public void GeneratQTEObj()
    {
        Debug.Log("Generate QTE");
        GameObject new_qte = Instantiate(qtePrefabs,
            new Vector3(1 * 2.0f, 0, 0), Quaternion.identity);
        new_qte.transform.parent = qteParent.transform;
        new_qte.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        new_qte.GetComponent<QTEObj>().timeToClear = 8f;
        onByOnNum++;

    }

    public void GeneratQTEObjs()
    {
        for (var i = 0; i < 8; i++)
        {
            GeneratQTEObj();
        }

    }

    public void ClearBeatQTEs()
    {
        foreach (Transform child in qteParent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        currentIndex = 0;
    }

    public void TriggerChildByCurrentIndex()
    {
        if (qteParent.transform.childCount > currentIndex)
        {
            qteParent.transform.GetChild(currentIndex).GetComponent<QTEObj>().ChangeColor(currentIndex);
            currentIndex = (currentIndex + 1) % 8;
        }
        else
        {
            Debug.Log("Fail");
        }
        Debug.Log("Current Index"+QTESystem.m_Instance.currentIndex);
    }
    private void Update()
    {
        if (onByOnNum == 8)
        {
            CancelInvoke(nameof(GeneratQTEObj));
            StartCoroutine(Clear());
        }
    }
    IEnumerator Clear()
    {
        yield return new WaitForSeconds(6/0.9f);
        ClearBeatQTEs();
    }

    public void ResetQTE()
    {
        qte.fillAmount = 1f;
        qte.SetFillAmount();
        qte.m_WaitForAction = true;
    }

}
