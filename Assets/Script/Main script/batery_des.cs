using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batery_des : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject Player = GameObject.FindWithTag("Player");
        Vector2 Ppos = Player.transform.position;
        Vector2 Tpos = this.transform.position;
        float len = Ppos.y - Tpos.y;
        if (len > 1) Destroy(this.gameObject);
	}
}
