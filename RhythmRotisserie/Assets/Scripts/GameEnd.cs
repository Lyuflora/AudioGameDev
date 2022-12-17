using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Emitter = FMODUnity.StudioEventEmitter;

public class GameEnd : MonoBehaviour
{
    [Header("FMOD")]
    public Emitter winningEmitter;
    public Emitter failingEmitter;

    public bool isWinning;
    public Meat meat;

    private void Start()
    {
        if (isWinning)
        {
            winningEmitter.Play();
            meat.MeatCooked();
        }
        else
        {
            failingEmitter.Play();
            meat.MeatOvercooked();
        }
        meat.surface.enabled = true;
        //StartCoroutine(BackStartScene());
        
    }

    IEnumerator BackStartScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("StartScene");
    }
}
