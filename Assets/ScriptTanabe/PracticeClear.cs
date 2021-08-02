using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeClear : MonoBehaviour
{
    //てこのオブジェクト
    GameObject lever;

    private void Start()
    {   
        //てこのオブジェクトを取得
        lever = GameObject.Find("Lever");
    }

    void Update()
    {
        //てこのz方向角度が水平なら画面遷移(オイラー角取得時に誤差があるため、-1~1の間の角度を水平とする)
        if(-1 <= lever.transform.localEulerAngles.z && lever.transform.localEulerAngles.z <= 1){
    
         Debug.Log("Search1");
        
        FadeManager.Instance.LoadScene ("practice02Lever", 1f);
            
        } 
    }
}
