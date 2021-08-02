using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour
{
     // UI Text指定用
    public Text TextFrame;
    // 表示する変数
    private int frame;

    // Start is called before the first frame update
    void Start()
    {
       frame = 0; 
    }

    // Update is called once per frame
    void Update()
    {
       TextFrame.text = string.Format("{0:00000} frame", frame);
        frame++; 
    }
}
