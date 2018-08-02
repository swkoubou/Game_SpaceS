using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_com : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0.05f, 0);
	}
}
