using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour {
    float h, v;
    public float interval = 0.2f;
    private float nextTime = 0;
    private float power = 0;
    public float maxPower = 10f;
    private Vector2 direction;

    public int playernum = 1;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal_P"+playernum);
        v = Input.GetAxis("Vertical_P"+playernum);
        Debug.Log("H" + playernum + ": " + h);
        if (Input.GetButtonDown("Fire1_P" + playernum))
        {
            direction = new Vector2(h, v);
            GetComponent<Rigidbody2D>().AddForce(-direction * power * 100);
            power = 0;
        }
        if (Time.time >= nextTime)
        {
            if ((h != 0 || v != 0)&&power<maxPower)
            {
                power += 1;
            }
            else if(power>0)
            {
                power -= 1;
            }


            nextTime += interval;
        }
        
    }
}
