using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrackDrag : MonoBehaviour
{

    public GameObject marker;
    public GameObject mark1;
    public GameObject mark2;
    public int markNum;

    // Update is called once per frame
    void Update()
    {
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
        }
    }

    private IEnumerator OnTriggerEnter(Collider collision)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        markNum += 1;
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}