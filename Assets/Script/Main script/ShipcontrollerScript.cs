using UnityEngine;
using System.Collections; 

public class ShipcontrollerScript : MonoBehaviour {
    public float speed = 5;
    public float boost = 20;
    public float cool = 10;
    // Update is called once per frame
    void Update() {
        //左右
        float x = Input.GetAxisRaw("Horizontal");
        //上下
        float y = Input.GetAxisRaw("Vertical");
        //向きを求める
        Vector2 direction = new Vector2(x, y).normalized;

        if (Input.GetKey("left shift"))
        {
            float a = 10f;
            GetComponent<Rigidbody2D>().velocity = direction * boost;
        }
        else
        {
            //向きとスピードをかける
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        
        
	}
}
