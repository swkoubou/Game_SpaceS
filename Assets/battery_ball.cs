using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery_ball : MonoBehaviour {
    GameObject battery;
    public float Ball_speed = 0.05f;
	// Use this for initialization
	void Start () {
        battery = GameObject.Find("pivod-b1");
        battery1 b1 = battery.GetComponent<battery1>();


        float tRot = b1.b_rot;
        //Debug.Log(tRot);
        Vector3 Trot = this.transform.localEulerAngles;
        Trot.z = tRot+90;
        this.transform.localEulerAngles = Trot;
        
        Vector3 Tpso = this.transform.position;
        Tpso.x = b1.ppos.x;
        Tpso.y = b1.ppos.y;
        Tpso.z = -3;
        transform.position = Tpso;
    }
	
	// Update is called once per frame
	void Update () {

        GetComponent<Animator>().enabled = false;
        /* Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
         rigidbody.AddForce(new Vector2(-0.1f, 0));*/
        transform.Translate(new Vector2(0, Ball_speed));
	}
}
