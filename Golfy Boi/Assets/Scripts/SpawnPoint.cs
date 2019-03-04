using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject player;
    public int playerNum;
    public Sprite skin;

	// Use this for initialization
	void Start ()
    {
        print("Spawning Player "+playerNum+ " at "+ this.transform.position);
        Instantiate(player);
        player.transform.position = this.transform.position;
        player.GetComponent<ControllerMovement>().playernum = playerNum;
        player.GetComponent<SpriteRenderer>().sprite = skin;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
