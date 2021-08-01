using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunDog : MonoBehaviour
{
    //犬オブジェクトの開始時座標
    Vector3 startPosition;
    //犬オブジェクトの移動先座標
    Vector3 targetPosition;
    //てこのオブジェクト
    GameObject lever;
    //画面遷移済みフラグ
    bool isFaded;

    private void Start()
    {   
        //犬の開始時座標
        startPosition = GameObject.Find("Dog").transform.position;
        //犬の移動先座標
        targetPosition = GameObject.Find("DogGoal").transform.position;
        //てこのオブジェクトを取得
        lever = GameObject.Find("Lever");
        //画面遷移済みフラグをfalseに設定
        isFaded = false;
    }

    void Update()
    {
        //てこのz方向角度が水平なら犬を移動させる(オイラー角取得時に誤差があるため、-1~1の間の角度を水平とする)
        if(-1 <= lever.transform.localEulerAngles.z && lever.transform.localEulerAngles.z <= 1){
            transform.position = 
            Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 50);
        } else{
            //水平でない場合
            if(transform.position != targetPosition){
                //左側に渡りきっていなければ戻す
                transform.position = startPosition;

            }
        }

        if(transform.position == targetPosition && !isFaded){
                Debug.Log("TecoGood");
                FadeManager.Instance.LoadScene ("TecoGood", 1f);
                //フェードアウト：http://kuromikangames.com/article/475434825.html

                //遷移済みフラグをtrueにして何度も遷移しないようにする
                isFaded = true;
            }
    }
}
