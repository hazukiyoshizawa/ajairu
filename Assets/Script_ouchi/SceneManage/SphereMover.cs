using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <Summary>
/// オブジェクトを円周上で移動させるスクリプトです。
/// </Summary>
public class SphereMover : MonoBehaviour
{
    // 円の半径
    public float radius = 250f;

    //位相
    public float phase = 0f;

    // 初期位置
    Vector3 initPos;
    //Vector2 initPos;

    GameObject image_objectA;
    GameObject image_objectB;
    GameObject image_objectC;
    GameObject image_objectD;
    GameObject image_objectE;
    GameObject image_objectF;
    GameObject image_objectG;
    GameObject image_objectH;
    GameObject image_objectI;
    GameObject image_objectJ;
    GameObject image_objectK;
    GameObject image_objectL;
    GameObject ObjectButton;

    ButtonHoldDown buttonHoldDown;


    void Start()
    {
        // 初期位置を保持
        //initPos = gameObject.transform.position;
        initPos = this.transform.position;

        //満ち欠け画像オブジェクトを取得
        image_objectA = GameObject.Find("ShapeA");
        image_objectB = GameObject.Find("ShapeB");
        image_objectC = GameObject.Find("ShapeC");
        image_objectD = GameObject.Find("ShapeD");
        image_objectE = GameObject.Find("ShapeE");
        image_objectF = GameObject.Find("ShapeF");
        image_objectG = GameObject.Find("ShapeG");
        image_objectH = GameObject.Find("ShapeH");
        image_objectI = GameObject.Find("ShapeI");
        image_objectJ = GameObject.Find("ShapeJ");
        image_objectK = GameObject.Find("ShapeK");
        image_objectL = GameObject.Find("ShapeL");

        ObjectButton = GameObject.Find("IncreaseButton");
        buttonHoldDown = ObjectButton.GetComponent<ButtonHoldDown>();
        
    }

    void Update()
    {
        phase = buttonHoldDown.phase;

        //Debug.Log(phase);

        CalcPosition();
        
        if (0 > phase)
        {
            phase = 6.29f;
        }
        if (phase > 6.3)
        {
            phase = 0f;
        }

        //以下満ち欠け表示条件
        if (phase < 0.2625 || phase > 6.0375)
        {
            image_objectA.SetActive(true);
        }
        else
        {
            image_objectA.SetActive(false);
        }

        if (0.2625 < phase && phase < 0.7875)
        {
            image_objectB.SetActive(true);
        }
        else
        {
            image_objectB.SetActive(false);
        }

        if (0.7875 < phase && phase < 1.3125)
        {
            image_objectC.SetActive(true);
        }
        else
        {
            image_objectC.SetActive(false);
        }

        if (1.3125 < phase && phase < 1.8375)
        {
            image_objectD.SetActive(true);
        }
        else
        {
            image_objectD.SetActive(false);
        }

        if (1.8375 < phase && phase < 2.3625)
        {
            image_objectE.SetActive(true);
        }
        else
        {
            image_objectE.SetActive(false);
        }

        if (2.3625 < phase && phase < 2.8875)
        {
            image_objectF.SetActive(true);
        }
        else
        {
            image_objectF.SetActive(false);
        }

        if (2.8875 < phase && phase < 3.4125)
        {
            image_objectG.SetActive(true);
        }
        else
        {
            image_objectG.SetActive(false);
        }

        if (3.4125 < phase && phase < 3.9375)
        {
            image_objectH.SetActive(true);
        }
        else
        {
            image_objectH.SetActive(false);
        }

        if (3.9375 < phase && phase < 4.4625)
        {
            image_objectI.SetActive(true);
        }
        else
        {
            image_objectI.SetActive(false);
        }

        if (4.4625 < phase && phase < 4.9875)
        {
            image_objectJ.SetActive(true);
        }
        else
        {
            image_objectJ.SetActive(false);
        }

        if (4.9875 < phase && phase < 5.5125)
        {
            image_objectK.SetActive(true);
        }
        else
        {
            image_objectK.SetActive(false);
        }

        if (5.5125 < phase && phase < 6.0375)
        {
            image_objectL.SetActive(true);
        }
        else
        {
            image_objectL.SetActive(false);
        }

    }

    /// <Summary>
    /// オブジェクトの位置を計算するメソッドです。
    /// </Summary>
    void CalcPosition()
    {
        // 位相を計算します。
        //float phase = Time.time * 2 * Mathf.PI;

        // 現在の位置を計算します。
        float xPos = radius * Mathf.Cos(phase);
        float yPos = radius * Mathf.Sin(phase);

        // ゲームオブジェクトの位置を設定します。
        Vector3 pos = new Vector3(initPos.x + xPos, initPos.y + yPos + 1000, initPos.z);
        gameObject.transform.position = pos;
    }
}
