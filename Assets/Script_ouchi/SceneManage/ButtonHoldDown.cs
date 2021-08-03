using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoldDown : MonoBehaviour
{
    // ボタンを押したときtrue、離したときfalseになるフラグ
    private bool buttonDownFlag = false;

    public float phase = 0f;

    private float timeleft = 0.04f;

    private void Update()
    {
        if (buttonDownFlag)
        {
            // ボタンが押しっぱなしの状態の時にのみ「Hold」を表示する。
            Debug.Log("Hold");
            timeleft -= Time.deltaTime;
            if (timeleft <= 0.0)
            {
                if (0 > phase)
                {
                    phase = 6.29f;
                }
                if (phase > 6.3)
                {
                    phase = 0f;
                }
                timeleft = 0.04f; //1秒間に+25したい＝1/25秒毎に+1
                phase += 0.05f;
            }


        }
    }
    // ボタンを押したときの処理
    public void OnButtonDown()
    {
        Debug.Log("Down");
        buttonDownFlag = true;
    }
    // ボタンを離したときの処理
    public void OnButtonUp()
    {
        Debug.Log("Up");
        buttonDownFlag = false;
    }
}
