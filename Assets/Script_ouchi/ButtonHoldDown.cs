using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoldDown : MonoBehaviour
{
    // �{�^�����������Ƃ�true�A�������Ƃ�false�ɂȂ�t���O
    private bool buttonDownFlag = false;

    public float phase = 0f;

    private float timeleft = 0.04f;

    private void Update()
    {
        if (buttonDownFlag)
        {
            // �{�^�����������ςȂ��̏�Ԃ̎��ɂ̂݁uHold�v��\������B
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
                timeleft = 0.04f; //1�b�Ԃ�+25��������1/25�b����+1
                phase += 0.05f;
            }


        }
    }
    // �{�^�����������Ƃ��̏���
    public void OnButtonDown()
    {
        Debug.Log("Down");
        buttonDownFlag = true;
    }
    // �{�^���𗣂����Ƃ��̏���
    public void OnButtonUp()
    {
        Debug.Log("Up");
        buttonDownFlag = false;
    }
}
