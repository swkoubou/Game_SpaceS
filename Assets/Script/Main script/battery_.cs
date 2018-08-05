using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : MonoBehaviour {
    public float phai=0;//角度保持
    public GameObject Player;
    public int Mran = 50;//乱数のmax値
    Vector2 Ppos, Bpos;
    private float lenght_x,lenght_y;//playerとbatteryの差分位置保持
    public GameObject Ball;
    int i = 0;
    // Use this for initialization
    void Start()
    {
        Bpos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Ppos = Player.transform.position;
        lenght_x = (Bpos.x*Bpos.x) - (Ppos.x*Ppos.x);
        if (lenght_y > 11) GetComponent<SpriteRenderer>().enabled = false;
        else if (lenght_y < 11 && lenght_y > 0) GetComponent<SpriteRenderer>().enabled = true;
        if (enabled) {
            if (lenght_x > 0) { Ran(Ball); Phai(1); }
            else { Ran(Ball); Phai(0); }
        }
       
    }

    void Ran(GameObject ball)//大砲から弾を出す関数
    {
        int ra;
        ra = UnityEngine.Random.Range(0, Mran);
        if (ra == 0) Instantiate(ball);
        ball.transform.rotation = Quaternion.Euler(0f, 0f, phai);
        ball.transform.position = this.transform.position;
    }

    void Phai(int a)//大砲から出る弾の出先を決める関数
    {
        switch (a)
        {
            case 1:phai=UnityEngine.Random.Range(-80,-160);break;
            case 0:phai = UnityEngine.Random.Range(-10, 110);break;
        }
    }

}

