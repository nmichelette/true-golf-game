using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject s;
	// Use this for initialization
	void Start () {
        Instantiate(s, this.transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
