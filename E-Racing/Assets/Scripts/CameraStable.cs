using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script stabalizes the camera for the car
public class CameraStable : MonoBehaviour {

    public GameObject car;
    public float carX;
    public float carY;
    public float carZ;

	void Update () {
        //get rotation values of the car
        carX = car.transform.eulerAngles.x;
        carY = car.transform.eulerAngles.y;
        carZ = car.transform.eulerAngles.z;

        //makes cube rotate in the opposite direction of the cars rotation = stabalized view
        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ); // carX - carX = inverse (carX)
	}
}
