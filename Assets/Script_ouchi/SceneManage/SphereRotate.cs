using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <Summary>
/// �I�u�W�F�N�g���~����ňړ�������X�N���v�g�ł��B
/// </Summary>
public class SphereRotate : MonoBehaviour
{
    // �~�̔��a
    public float radius = 0f;

    //�ʑ�
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
