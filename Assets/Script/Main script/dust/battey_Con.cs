using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battey_Con : MonoBehaviour
{
    public GameObject Player;
    Vector2 Ppos, Bpos;
    private float lenght;
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
        lenght = Bpos.y - Ppos.y;
        if (lenght > 11) GetComponent<SpriteRenderer>().enabled = false;
        else if (lenght < 11 && lenght > 0) GetComponent<SpriteRenderer>().enabled = true;
        else if (lenght < -2) Destroy(this.gameObject);
        i++;
        if (i % 10 == 0) Ran(Ball);
    }

    void Ran(GameObject ball)
    {
        int ra;
        ra = Random.Range(0, 10);
        if (ra == 0) Instantiate(ball);
        ball.transform.rotation = Quaternion.Euler(0f, 0f, transform.localEulerAngles.z);
        ball.transform.position = this.transform.position;
    }
}
