using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHand : MonoBehaviour
{
    // 手の初期座標
    Vector3 handStart;
    // 手の移動先座標
    Vector3 handGoal;
    // 手がゴールまで移動した回数
    int moveCount = 0;
    // 手を何回動かすか
    int maxMoveCount = 50;

    // Start is called before the first frame update
    void Start()
    {
        // 手の初期座標を取得
        handStart = transform.localPosition;     
        // 手の移動先座標を取得
        handGoal = GameObject.Find("HandGoal").transform.localPosition;    
    }

    // Update is called once per frame
    void Update()
    {   
        float sin = Mathf.Sin(Time.time * 2) * 40.0f;
        
        this.transform.localPosition = new Vector3(handStart.x, handStart.y - sin, handStart.z);
        
        // //指定回数動いていないとき
        // if(moveCount < maxMoveCount)
        // {
        //     // 手がゴールまで到達した
        //     if(transform.localPosition == handGoal)
        //     {
        //         // 移動回数をインクリメント
        //         moveCount++;
        //         if(moveCount >= maxMoveCount)
        //         {
        //             // 手を非表示
        //             this.gameObject.SetActive(false);
        //         }
        //         // 手を初期位置に戻す
        //         transform.localPosition = handStart;
        //     } else {
        //         // 手をゴールまで動かす
        //         transform.localPosition = 
        //         Vector3.MoveTowards(transform.localPosition, handGoal, Time.deltaTime * 10);
        //     }
        // }
         
    }
}
