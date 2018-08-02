using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_con : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(0, 0.1f));
    }
}
