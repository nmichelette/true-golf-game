using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {

    public string sceneTo;
	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void startGame()
    {
        Debug.Log("start pressed");
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneTo);
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
