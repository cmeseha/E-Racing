using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class BrainControlActive : MonoBehaviour {

    public GameObject brainControl;

	// Use this for initialization
	void Start () {
        brainControl.GetComponent<CarController>().enabled = true;
        brainControl.GetComponent<CarAIControl>().enabled = true;
    }

}
