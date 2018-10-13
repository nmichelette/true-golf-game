using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Debug.Log("Mouse Down");
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.position.y);
                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
    }

}
