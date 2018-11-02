using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class panelEsc : MonoBehaviour {
    public GameObject panel;
 
	// Use this for initialization
	void Start () {
        panel.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.gameObject.SetActive(true);
        }
	}
}
