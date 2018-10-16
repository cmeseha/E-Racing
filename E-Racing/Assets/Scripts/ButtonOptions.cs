using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(2); //loads the track selection screen
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //these buttons are for the track selection buttons
    public void Track1()
    {
        SceneManager.LoadScene(1);
    }

    public void Track2()
    {
        SceneManager.LoadScene(3);
    }




}
