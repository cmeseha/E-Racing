using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //for references the UI elements on screen

public class LapTimeManager : MonoBehaviour {

    //static allows variable to be referenced in LapComplete.cs
    public static int mins;
    public static int secs;
    public static float millis;
    public static string milliDisplay;

    //UI objects
    public GameObject minBox;
    public GameObject secBox;
    public GameObject milliBox;

    //referenced in LapComplete.cs
    public static float RawTime;


	// Update is called once per frame
	void Update () {
        millis += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        milliDisplay = millis.ToString("F0");
        milliBox.GetComponent<Text>().text = "" + milliDisplay;
        //resets milliseconds after 9 back to 0
        if (millis >= 10) {
            millis = 0;
            secs += 1;
        }

        //adds a 0 before integers 1-9 for seconds
        if (secs <= 9) {
            secBox.GetComponent<Text>().text = "0" + secs + ".";
        } else {
            secBox.GetComponent<Text>().text = "" + secs + ".";
        }

        if (secs >= 60) {
            secs = 0;
            mins += 1;
        }

        //adds a 0 before integers 1-9 for minutes
        if (mins <= 9) {
            minBox.GetComponent<Text>().text = "0" + mins + ":";
        } else {
            minBox.GetComponent<Text>().text = "" + mins + ":";
        }
    }
}
