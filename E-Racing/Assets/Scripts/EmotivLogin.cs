using System;
using System.Threading;
// ﻿using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using EnvironmentVariablesNS;
using CortexAccess;

public class EmotivLogin : MonoBehaviour {

	// Setting username and password variables
	EnvironmentVariables environmentVariables = new EnvironmentVariables();

	// Process from CortexAccess - this takes care of the logging in
	public Process p = new Process();

	// Use this for initialization
	void Start () {
		// This makes it so that the Process exists between scenes
		DontDestroyOnLoad(this.gameObject);

		// Registering EEG data received event
		// p.OnEEGDataReceived += OnEEGDataReceived;
		// p.SessionCtr.OnSubcribeEEGOK += OnEEGDataReceived;

		Thread.Sleep(10000); //wait for querrying user login, query headset
		if(String.IsNullOrEmpty(p.GetUserLogin())) {
			p.Login(Environment.GetEnvironmentVariable("username"),
			 Environment.GetEnvironmentVariable("password"));
				Thread.Sleep(5000); //wait for logining
			}
			// Show username login
			Console.WriteLine("Username :" + p.GetUserLogin());

			// Might not need to call this

			// if(p.AccessCtr.IsLogin) {
			// 	// Send Authorize
			// 	p.Authorize(LicenseId, DebitNumber);
			// 	Thread.Sleep(5000); //wait for authorizing
			// }

			if(!p.IsHeadsetConnected()) {
				// DEBUGGING
				Console.WriteLine("Headset not connected - querying headset");
				p.QueryHeadset();
				Thread.Sleep(10000); //wait for querying headset and create session
			}
			if(!p.IsCreateSession) {
				// DEBUGGING
				Console.WriteLine("Session not created - creating session");
				p.CreateSession();
				Thread.Sleep(5000);
			}

			if(p.IsCreateSession) {
				// DEBUGGING
				Console.WriteLine("Session IS created - subscribing to EEG");
				// Subcribe EEG data
				p.SubcribeData("eeg");
				Thread.Sleep(5000);
			}

			// Query Profile
			p.QuerryProfiles();
			Thread.Sleep(5000);

			// get Detection Information
			//p.QuerryDetectionInfo("mentalCommand");
			//Thread.Sleep(2000); //wait for get detection information

			// Check Profile existed
			// Then load an existed profile or create a new Profile

			// TODO abstract ProfileName later
			String ProfileName = "chris";
			if (p.IsProfilesExisted(ProfileName)) {
				p.LoadProfile(ProfileName);
			}
			else {
				Console.WriteLine("Profile not found!");
				// p.CreateProfile(ProfileName);
				Thread.Sleep(2000);
				// throw new Exception("Profile not found!");
			}
	}

	// Update is called once per frame
	void Update () {

	}
}
