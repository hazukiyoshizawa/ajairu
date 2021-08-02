using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    //ボタンを押したらパネル変更
    public void OnRightArrow()
    {
        transform.localPosition = new Vector2(-1000, 0);
    }

    public void OnRightArrow2()
    {
        Transform myTransform = this.transform;

        Vector3 pos =myTransform.position;
        pos.x += -562;

        myTransform.position = pos;
    }

        public void OnRightArrow2Double()
    {
        Transform myTransform = this.transform;

        Vector3 pos =myTransform.position;
        pos.x += -1124;

        myTransform.position = pos;
    }
}
