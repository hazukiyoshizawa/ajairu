using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <Summary>
/// �I�u�W�F�N�g���~����ňړ�������X�N���v�g�ł��B
/// </Summary>
public class SphereMover : MonoBehaviour
{
    // �~�̔��a
    public float radius = 250f;

    //�ʑ�
    public float phase = 0f;

    // �����ʒu
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
    GameObject ObjectButton;

    ButtonHoldDown buttonHoldDown;


    void Start()
    {
        // �����ʒu��ێ�
        //initPos = gameObject.transform.position;
        initPos = this.transform.position;

        //���������摜�I�u�W�F�N�g���擾
        image_objectA = GameObject.Find("ShapeA");
        image_objectB = GameObject.Find("ShapeB");
        image_objectC = GameObject.Find("ShapeC");
        image_objectD = GameObject.Find("ShapeD");
        image_objectE = GameObject.Find("ShapeE");
        image_objectF = GameObject.Find("ShapeF");
        image_objectG = GameObject.Find("ShapeG");
        image_objectH = GameObject.Find("ShapeH");

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

        //�ȉ����������\������
        if (phase < 0.394 || phase > 5.906)
        {
            image_objectG.SetActive(true);
        }
        else
        {
            image_objectG.SetActive(false);
        }

        if (0.394 < phase && phase < 1.181)
        {
            image_objectH.SetActive(true);
        }
        else
        {
            image_objectH.SetActive(false);
        }

        if (1.181 < phase && phase < 1.969)
        {
            image_objectA.SetActive(true);
        }
        else
        {
            image_objectA.SetActive(false);
        }

        if (1.969 < phase && phase < 2.756)
        {
            image_objectB.SetActive(true);
        }
        else
        {
            image_objectB.SetActive(false);
        }

        if (2.756 < phase && phase < 3.544)
        {
            image_objectC.SetActive(true);
        }
        else
        {
            image_objectC.SetActive(false);
        }

        if (3.544 < phase && phase < 4.331)
        {
            image_objectD.SetActive(true);
        }
        else
        {
            image_objectD.SetActive(false);
        }

        if (4.331 < phase && phase < 5.119)
        {
            image_objectE.SetActive(true);
        }
        else
        {
            image_objectE.SetActive(false);
        }

        if (5.119 < phase && phase < 5.906)
        {
            image_objectF.SetActive(true);
        }
        else
        {
            image_objectF.SetActive(false);
        }

    }

    /// <Summary>
    /// �I�u�W�F�N�g�̈ʒu���v�Z���郁�\�b�h�ł��B
    /// </Summary>
    void CalcPosition()
    {
        // �ʑ����v�Z���܂��B
        //float phase = Time.time * 2 * Mathf.PI;

        // ���݂̈ʒu���v�Z���܂��B
        float xPos = radius * Mathf.Cos(phase);
        float yPos = radius * Mathf.Sin(phase);

        // �Q�[���I�u�W�F�N�g�̈ʒu��ݒ肵�܂��B
        Vector3 pos = new Vector3(initPos.x + xPos, initPos.y + yPos + 1000, initPos.z);
        gameObject.transform.position = pos;
    }
}
