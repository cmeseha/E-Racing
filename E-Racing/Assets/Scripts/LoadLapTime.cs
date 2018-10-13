using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

    public int mins;
    public int secs;
    public float millis;

    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject milliDisplay;

    void Start()
    {
        mins = PlayerPrefs.GetInt("MinSave");
        secs = PlayerPrefs.GetInt("SecSave");
        millis = PlayerPrefs.GetFloat("MilliSave");

        if (mins < 9)
        {
            minDisplay.GetComponent<Text>().text = "0" + mins + ":";
        } else
        {
            minDisplay.GetComponent<Text>().text = "" + mins + ":";
        }
        if (secs < 9)
        {
            secDisplay.GetComponent<Text>().text = "0" + secs + ".";
        } else
        {
            secDisplay.GetComponent<Text>().text = "" + secs + ".";
        }
     
        milliDisplay.GetComponent<Text>().text = "" + millis;

    }
}
