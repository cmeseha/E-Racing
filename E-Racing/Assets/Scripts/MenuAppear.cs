using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour {

    public GameObject touchButton;
    public GameObject touchText;
    public GameObject menuButtons;

    public void StartMenu()
    {
        touchButton.SetActive(false);
        touchText.SetActive(false);
        menuButtons.SetActive(true);
    }
}
