using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// オブジェクトをゴールに設定したオブジェクトまで指定回数動かす
public class MoveArrow01 : MonoBehaviour
{
    // 矢印の初期座標
    Vector3 arrowStart;
    // 矢印の移動先座標
    Vector3 arrowGoal;
    // 矢印がゴールまで移動した回数
    int moveCount = 0;
    // 矢印を何回動かすか
    int maxMoveCount = 5;

    // Start is called before the first frame update
    void Start()
    {
        // 矢印の初期座標を取得
        arrowStart = transform.position;     
        // 矢印の移動先座標を取得
        arrowGoal = GameObject.Find("ArrowGoal").transform.position;    
    }

    // Update is called once per frame
    void Update()
    {   
        //指定回数動いていないとき
        if(moveCount < maxMoveCount)
        {
            // 矢印がゴールまで到達した
            if(transform.position == arrowGoal)
            {
                // 移動回数をインクリメント
                moveCount++;
                // 矢印を初期位置に戻す
                transform.position = arrowStart;
            } else {
                // 矢印をゴールまで動かす
                transform.position = 
                Vector3.MoveTowards(transform.position, arrowGoal, Time.deltaTime * 20);
            }
        } else { //指定回数動いた
            this.gameObject.SetActive(false);
        }
    }
}
