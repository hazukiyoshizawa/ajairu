using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <Summary>
/// オブジェクトを円周上で移動させるスクリプトです。
/// </Summary>
public class SphereRotate : MonoBehaviour
{
    // 円の半径
    public float radius = 0f;

    //位相
    public float phase = 0f;

    GameObject ObjectButton;

    ButtonHoldDown buttonHoldDown;


    void Start()
    {
        ObjectButton = GameObject.Find("IncreaseButton");
        buttonHoldDown = ObjectButton.GetComponent<ButtonHoldDown>();

    }

    void Update()
    {
        phase = buttonHoldDown.phase;
        transform.Rotate(new Vector3(0, 0, phase));


    }
}
