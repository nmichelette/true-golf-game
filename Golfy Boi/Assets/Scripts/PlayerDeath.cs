using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    public Camera cam;
    GameObject[] players;
    private int direction;//1 right, 2 left, 3 up, 4 down
    public int Direction
    {
        get
        {
            return direction;
        }

        set
        {
            direction = value;
        }
    }

    // Use this for initialization
    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        direction = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
            Vector3 curr = players[i].gameObject.transform.position;
            Vector3 campos = cam.transform.position;

            //Use to test if player is killed while in-bounds
            //print("Player x:"+ curr.x + "  Player y:" + curr.y);
            //print("Cam x:" + campos.x + "  Cam y:" + campos.y);
            //print("Camera Height:"+ cam.orthographicSize);
            //print("Camera Width:" + cam.orthographicSize * cam.aspect);

            switch (direction)
            {
                case 1://right
                    if ((curr.y < campos.y - cam.orthographicSize || curr.y > campos.y + cam.orthographicSize) || curr.x < campos.x - cam.orthographicSize * cam.aspect)
                    {
                        Destroy(players[i]);
                        print("Killed Player "+ (i + 1));
                    }
                    break;
                case 2://left
                    if ((curr.y < campos.y - cam.orthographicSize || curr.y < campos.y + cam.orthographicSize) || curr.x > campos.x + cam.orthographicSize * cam.aspect)
                    {
                        Destroy(players[i]);
                        print("Killed Player " + (i + 1));
                    }
                    break;
                case 3: //up
                    if (curr.y < campos.y - cam.orthographicSize  || (curr.x < campos.x - cam.orthographicSize * cam.aspect || curr.x>campos.x +cam.orthographicSize*cam.aspect))
                    {
                        Destroy(players[i]);
                        print("Killed Player " + (i + 1));
                    }
                    break;
                case 4://down
                    if (curr.y > campos.y + cam.orthographicSize || (curr.x < campos.x - cam.orthographicSize * cam.aspect || curr.x > campos.x + cam.orthographicSize * cam.aspect))
                    {
                        Destroy(players[i]);
                        print("Killed Player " + (i + 1));
                    }
                    break;
            }
        }
    }
}
