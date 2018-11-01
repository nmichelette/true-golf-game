using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingMainMenu : MonoBehaviour {
    Vector2 offset;
    Material mat;
    public float XOffset, YOffset;
	// Use this for initialization
	void Start ()
    {
        offset = new Vector2(XOffset, YOffset);
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mat.mainTextureOffset += offset * Time.deltaTime;
	}
}
