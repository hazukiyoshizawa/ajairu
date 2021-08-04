using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeClear : MonoBehaviour
{
    //てこのオブジェクト
    GameObject lever;

    //てこが水平になっている間のフレーム数
    int clearFrame;

    //画面遷移済みフラグ
    bool isFaded;

    private void Start()
    {   
        //てこのオブジェクトを取得
        lever = GameObject.Find("Lever");

        //フレーム数を0で初期化
        clearFrame = 0;

        //画面遷移済みフラグをfalseに設定
        isFaded = false;
    }

    void Update()
    {
        //一定フレーム数の間、てこが水平になっている=問題をクリアしている
        if(clearFrame > 30 && !isFaded){
            //次の画面に遷移
            FadeManager.Instance.LoadScene ("Practice01Clear", 1f);

            isFaded = true;
        }

        //てこのz方向角度が水平なら画面遷移(オイラー角取得時に誤差があるため、-1~1の間の角度を水平とする)
        if(-1 <= lever.transform.localEulerAngles.z && lever.transform.localEulerAngles.z <= 1){
            //水平状態ならフレーム数をインクリメント
            clearFrame++;
        } else {
            //水平状態ではない(間違っている)ならフレーム数を0に
            clearFrame = 0;
        }
    }
}
