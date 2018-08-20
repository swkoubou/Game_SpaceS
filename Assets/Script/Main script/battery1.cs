using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery1 : MonoBehaviour {
    public GameObject Ball;
    Animator anim;
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        Quaternion t = this.transform.rotation;
        float tp = t.eulerAngles.z ;
        GameObject Player = GameObject.FindWithTag("Player");
        Debug.Log(tp);
        
        /*if (tp >= 45)
        {
            Instantiate(Ball.gameObject);
            this.GetComponent<Animator>().speed = 0;

        }*/
    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
      //  float  phai;
        if (collision.gameObject.tag == "Player") {

            this.GetComponent<Animator>().speed = 0;
         //   phai = this.transform.localEulerAngles.z;//角度の格納
          //  for (; phai < phai + 10; phai += 0.1f) 
            
                }
    }*/
}
