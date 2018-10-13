using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

    public GameObject lapCompleteTrig;
    public GameObject halfLabTrig;

    void OnTriggerEnter()
    {
        lapCompleteTrig.SetActive(true);
        halfLabTrig.SetActive(false);
    }

}
