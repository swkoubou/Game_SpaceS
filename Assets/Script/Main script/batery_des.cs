using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batery_des : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject Camera = GameObject.FindWithTag("MainCamera");
        Vector2 Cpos = Camera.transform.position;
        Vector2 Tpos = this.transform.position;
        float len = Cpos.y - Tpos.y;
        if (len > 5) Destroy(this.gameObject);
	}
}
