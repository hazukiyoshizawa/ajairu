using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChangerJunpei : MonoBehaviour
{
    //ボタンを押したらパネル変更
    public void PanelMove0_0()
    {
        transform.localPosition = new Vector2(0, 0);
    }
    public void PanelMove0_1()
    {
        transform.localPosition = new Vector2(-2000, 0);
    }
    public void PanelMove0_2()
    {
        transform.localPosition = new Vector2(-4000, 0);
    }
    public void PanelMove1_0()
    {
        transform.localPosition = new Vector2(0, 1000);
    }
    public void PanelMove1_1()
    {
        transform.localPosition = new Vector2(-2000, 1000);
    }
    public void PanelMove2_0()
    {
        transform.localPosition = new Vector2(0, 2000);
    }
    public void PanelMove3_0()
    {
        transform.localPosition = new Vector2(0, 3000);
    }

    public void PanelMove3_1()
    {
        transform.localPosition = new Vector2(-2000, 3000);
    }
    public void PanelMove2_1()
    {
        transform.localPosition = new Vector2(-2000, 2000);
    }
}
