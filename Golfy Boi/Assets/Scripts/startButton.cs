using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void startGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("testScene");
    }

    public void endGame()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void credits()
    {
        Time.timeScale = 1;

    }
}
