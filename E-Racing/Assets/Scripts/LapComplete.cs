using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public float RawTime;

    public GameObject RaceFinish;

    public GameObject RestartButton;


    private void OnTriggerEnter() {
        RaceFinish.SetActive(true); //starts rotation cutscene
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.RawTime <= RawTime)
        {
            if (LapTimeManager.secs <= 9)
            {
                SecDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secs + ".";
            }
            else
            {
                SecDisplay.GetComponent<Text>().text = "" + LapTimeManager.secs + ".";
            }
            if (LapTimeManager.mins <= 9)
            {
                MinDisplay.GetComponent<Text>().text = "0" + LapTimeManager.mins + ".";
            }
            else
            {
                MinDisplay.GetComponent<Text>().text = "" + LapTimeManager.mins + ".";
            }

            MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.millis;
        }

        //saves players time 
        PlayerPrefs.SetInt("MinSave", LapTimeManager.mins);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.secs);
        PlayerPrefs.SetFloat("MilliSave", LapTimeManager.millis);
        PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

        LapTimeManager.mins = 0;
        LapTimeManager.secs = 0;
        LapTimeManager.millis = 0;
        LapTimeManager.RawTime = 0; 

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);
        RestartButton.SetActive(true);

    }

}
