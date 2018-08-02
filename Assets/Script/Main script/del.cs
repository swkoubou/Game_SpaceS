using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class del : MonoBehaviour {

    public GameObject Player;
    Vector2 Ppos, Bpos;
    private float lenght;
    // Use this for initialization
    void Start () {
        Bpos = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Ppos = Player.transform.position;
        lenght = Bpos.y - Ppos.y;
        if (lenght > 11) GetComponent<SpriteRenderer>().enabled = false;
        else if (lenght < 11 && lenght > 0) GetComponent<SpriteRenderer>().enabled = true;
        else if (lenght < -2) Destroy(this.gameObject);
    }
}
