using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;
    private GameObject[] players;
    private int playerCount;
    private int direction;//1=right, 2=left, 3=up, 4=down
    public PlayerDeath death;
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
    void Start()
    {
        offset = new Vector3(0.0f, 0.0f, -10.0f);
        players = GameObject.FindGameObjectsWithTag("Player");
        playerCount = players.Length;
        death = GetComponent<PlayerDeath>();
        direction = 1;
        target = players[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        if (target != null)
        {
            Vector3 yerd = new Vector3(0, 0, 0);
            switch (direction)
            {
                case 1://right

                    yerd = new Vector3(target.transform.position.x, 0, 0);
                    transform.position = Vector3.Lerp(transform.position, yerd + offset, 0.25f);
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].gameObject.transform.position.x > target.transform.position.x)
                        {
                            target = players[i];
                        }
                    }
                    break;
                case 2://left
            
                    yerd = new Vector3(target.transform.position.x, 0, 0);
                    transform.position = Vector3.Lerp(transform.position, yerd + offset, 0.25f);
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].gameObject.transform.position.x < target.transform.position.x)
                        {
                            target = players[i];
                        }
                    }
                    break;
                case 3://up
                    yerd = new Vector3(0, target.transform.position.y, 0);
                    transform.position = Vector3.Lerp(transform.position, yerd + offset, 0.25f);
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].gameObject.transform.position.y > target.transform.position.y)
                        {
                            target = players[i];
                        }
                    }
                    break;
                case 4://down
                    yerd = new Vector3(0, target.transform.position.y, 0);
                    transform.position = Vector3.Lerp(transform.position, yerd + offset, 0.25f);
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].gameObject.transform.position.y < target.transform.position.y)
                        {      
                            target = players[i];
                        }
                    }
                    break;
                default:
                    direction = 1;
                    break;
            }
        }
        else
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].gameObject.transform.position.x > 0)
                {
                    target = players[i];
                }
            }
        }
    }
}