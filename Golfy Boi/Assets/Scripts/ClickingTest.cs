using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingTest : MonoBehaviour {
    private bool isDown = false;


    private Vector3 coords;
    private float distance;
    private Vector3 direction;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(isDown)
        {
            
        }
    }

    void OnMouseDown()
    {
        isDown = true;
        coords = Input.mousePosition;
    }
    void OnMouseUp()
    {
        
        isDown = false;
        direction = coords.normalized;
        distance = Mathf.Sqrt(Mathf.Pow((Input.mousePosition.y-coords.y), 2)+ Mathf.Pow((Input.mousePosition.x - coords.x), 2));
        Debug.Log(distance);
        GetComponent<Rigidbody2D>().AddForce(coords);
    }
}
