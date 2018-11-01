using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CortexAccess;

public class BrainControl : MonoBehaviour {


	// Use this for initialization
	void Start () {
		GameObject emotivLogin = GameObject.Find("EmotivLoginObject");
		EmotivLogin emotivLoginScript = emotivLogin.GetComponent<EmotivLogin>();
		// registering event (using own function to handle events)
		emotivLoginScript.p.OnEEGDataReceived += OnEEGDataReceived;
		emotivLoginScript.p.SessionCtr.OnSubcribeEEGOK += OnEEGDataReceived;

	}

	// Update is called once per frame
	void Update () {

	}

	private static void OnEEGDataReceived(object sender, ArrayList eegData) {
		// this is where we do what we need to do to the data
	}
}
