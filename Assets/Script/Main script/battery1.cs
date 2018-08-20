using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery1 : MonoBehaviour {
    public GameObject Ball;
    Animator anim;
    float time;
    int ttime;
    public float b_rot;
    public Vector2 ppos;
    GameObject Player;
    // Use this for initialization
    void Start () {
       Player= GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        ppos = this.transform.position;
        b_rot = this.transform.localEulerAngles.z;
        //Debug.Log(b_rot);
             
        time += Time.deltaTime;
        if (time >= 0.5f)
        {
            time = 0;
            Instantiate(Ball);
        }
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
