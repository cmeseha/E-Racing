using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrack : MonoBehaviour {

    public GameObject marker;
    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject mark4;
    public GameObject mark5;
    public GameObject mark6;
    public GameObject mark7;
    public GameObject mark8;
    public GameObject mark9;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;
    public GameObject mark18;
    public GameObject mark19;
    public int markNum;

    // Update is called once per frame
    void Update () {
        switch (markNum)
        {
            case 0:
                marker.transform.position = mark1.transform.position;
                marker.transform.rotation = mark1.transform.rotation;
                break;
            case 1:
                marker.transform.position = mark2.transform.position;
                marker.transform.rotation = mark2.transform.rotation;
                break;
            case 2:
                marker.transform.position = mark3.transform.position;
                marker.transform.rotation = mark3.transform.rotation;
                break;
            case 3:
                marker.transform.position = mark4.transform.position;
                marker.transform.rotation = mark4.transform.rotation;
                break;
            case 4:
                marker.transform.position = mark5.transform.position;
                marker.transform.rotation = mark5.transform.rotation;
                break;
            case 5:
                marker.transform.position = mark6.transform.position;
                marker.transform.rotation = mark6.transform.rotation;
                break;
            case 6:
                marker.transform.position = mark7.transform.position;
                marker.transform.rotation = mark7.transform.rotation;
                break;
            case 7:
                marker.transform.position = mark8.transform.position;
                marker.transform.rotation = mark8.transform.rotation;
                break;
            case 8:
                marker.transform.position = mark9.transform.position;
                marker.transform.rotation = mark9.transform.rotation;
                break;
            case 9:
                marker.transform.position = mark10.transform.position;
                marker.transform.rotation = mark10.transform.rotation;
                break;
            case 10:
                marker.transform.position = mark11.transform.position;
                marker.transform.rotation = mark11.transform.rotation;
                break;
            case 11:
                marker.transform.position = mark12.transform.position;
                marker.transform.rotation = mark12.transform.rotation;
                break;
            case 12:
                marker.transform.position = mark13.transform.position;
                marker.transform.rotation = mark13.transform.rotation;
                break;
            case 13:
                marker.transform.position = mark14.transform.position;
                marker.transform.rotation = mark14.transform.rotation;
                break;
            case 14:
                marker.transform.position = mark15.transform.position;
                marker.transform.rotation = mark15.transform.rotation;
                break;
            case 15:
                marker.transform.position = mark16.transform.position;
                marker.transform.rotation = mark16.transform.rotation;
                break;
            case 16:
                marker.transform.position = mark17.transform.position;
                marker.transform.rotation = mark17.transform.rotation;
                break;
            case 17:
                marker.transform.position = mark18.transform.position;
                marker.transform.rotation = mark18.transform.rotation;
                break;
            case 18:
                marker.transform.position = mark19.transform.position;
                marker.transform.rotation = mark19.transform.rotation;
                break;
        }
	}

    private IEnumerator OnTriggerEnter(Collider collision)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        markNum += 1;
        if (markNum >= 19)
        {
            markNum = 0;
        }
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
