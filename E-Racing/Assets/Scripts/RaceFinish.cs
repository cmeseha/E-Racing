using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

    public GameObject car;
    public GameObject finishCam;
    public GameObject regularCam;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
      //  car.SetActive(false);
      //  CarController.m_Topspeed = 0.0f;
       // CarAIControl.m_AccelSensitivity = 0.0f;

       // car.GetComponent<CarController>().enabled = false;
        car.GetComponent<CarAIControl>().enabled = false;
        //car.SetActive(true);
        finishCam.SetActive(true);
        regularCam.SetActive(false);
    }
}
