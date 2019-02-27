using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    public CameraScript script;
    public Camera cam;
    GameObject[] players;
	// Use this for initialization
	void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        script = GetComponent<CameraScript>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].gameObject.transform.position.y < -10)
            {
                Debug.Log("cant see" + players[i]);
                Destroy(players[i]);
                script.updatePlayers();
            }
        }
    }
}
