using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;
    private GameObject[] players;
    private int playerCount;
    private float greatestX;
    // Use this for initialization
    void Start()
    {
        offset = new Vector3(0.0f, 0.0f, -10.0f);
        players = GameObject.FindGameObjectsWithTag("Player");
        playerCount = players.Length;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        if (target != null)
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, 0.25f);
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].gameObject.transform.position.x > target.transform.position.x)
                {
                    greatestX = target.transform.position.x;
                    target = players[i];
                }
            }
        }
        else
        {
            Debug.Log("ungabunga");
            for (int i = 0; i < players.Length; i++)
            {
                Debug.Log(players[i].ToString());
                if (players[i].gameObject.transform.position.x > 0)
                {
                    target = players[i];
                }
            }
        }
    }
}