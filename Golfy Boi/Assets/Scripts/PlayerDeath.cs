using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    GameObject[] players;
	// Use this for initialization
	void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].GetComponent<Renderer>().isVisible == false)
            {
                Debug.Log("cant see" + players[i]);
            }
        }
	}
}
