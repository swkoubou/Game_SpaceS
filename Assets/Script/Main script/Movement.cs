using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindWithTag("Player");//Tag:Playerの検索
        Vector2 Ppos = Player.transform.position;//Ppos=自機の位置
        Vector2 Tpos = this.transform.position;//このプログラムの及ぶ位置の取得
        float len = Ppos.y - Tpos.y;
        if(len >= 10) Move(Tpos);//関数Moveの呼び出し
    }
    void Move(Vector2 Tpos) {//動作:背景の移動
        Tpos.y += 26;
        transform.position = Tpos;
    }
}
