using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public GameObject CountDown;
    public AudioSource GetReady;
    public GameObject LapTimer;
    public GameObject brainControls;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);

        GetReady.Play(); //change this audio
        LapTimer.SetActive(true);
        brainControls.SetActive(true);
        StartCoroutine(ThinkText());
    }

    IEnumerator ThinkText()
    {
        CountDown.GetComponent<Text>().text = "THINK!!!";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(2);
        CountDown.SetActive(false);

    }
}
