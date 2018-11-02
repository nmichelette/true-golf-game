using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class panelEsc : MonoBehaviour {
    public GameObject panel;
    bool isActive = false;

    public AudioSource audi;
	// Use this for initialization
	void Start () {
        panel.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isActive = !isActive;
            panel.gameObject.SetActive(isActive);
            if (isActive)
            {
                audi.Play();
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
