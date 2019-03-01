using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingMovement : MonoBehaviour {
    private bool isDown = false;
    private Vector2 coords;
    private float distance;
    private Vector2 direction;
    private Vector2 coords2;
    public float interval = 0.2f;
    private float nextTime = 0;
    private float power = 0;
    private float maxDistance = 100.0f;
    public float maxPower = 100.0f;



    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            isDown = true;
            coords = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            isDown = false;
            coords2 = Input.mousePosition;


            direction = new Vector2((coords2.x - coords.x) / Mathf.Sqrt(Mathf.Pow((coords2.x - coords.x), 2) + Mathf.Pow((coords2.y - coords.y), 2)), (coords2.y - coords.y) / Mathf.Sqrt(Mathf.Pow((coords2.x - coords.x), 2) + Mathf.Pow((coords2.y - coords.y), 2)));
            GetComponent<Rigidbody2D>().AddForce(-direction * power * 100);
            power = 0;
            coords = new Vector2(0, 0);
            coords2 = new Vector2(0, 0);
        }
        if (Time.time >= nextTime)
        {
            if(isDown)
            {
                distance = Mathf.Sqrt(Mathf.Pow((Input.mousePosition.y - coords.y), 2) + Mathf.Pow((Input.mousePosition.x - coords.x), 2));
                if (distance>maxDistance && power<maxPower)
                {
                    power += 10;
                }
                else if(distance<maxDistance && distance/maxDistance<power/maxPower)
                {
                    power -= 1;
                }
                else if (distance < maxDistance && distance / maxDistance > power / maxPower)
                {
                    power += 10;
                }
            }

            

            nextTime += interval;
        }
    }

    //void OnMouseDown()
    //{
    //    isDown = true;
    //    coords = Input.mousePosition;
    //}
    //void OnMouseUp()
    //{
        
    //    isDown = false;
    //    coords2 = Input.mousePosition;


      //  direction = new Vector2((coords2.x - coords.x)/Mathf.Sqrt(Mathf.Pow((coords2.x - coords.x), 2) + Mathf.Pow((coords2.y - coords.y), 2)), (coords2.y - coords.y)/ Mathf.Sqrt(Mathf.Pow((coords2.x - coords.x), 2) + Mathf.Pow((coords2.y - coords.y), 2)));
     //   GetComponent<Rigidbody2D>().AddForce(-direction*power*100);
     //   power = 0;
      //  coords = new Vector2(0, 0);
     //   coords2 = new Vector2(0, 0);
   // }
}
