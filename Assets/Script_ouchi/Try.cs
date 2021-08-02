using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Drawing;



public class Try : MonoBehaviour
{
    string[] choiceList = new string[3];
    // 選択ログ
    
    // Image[] imageList = new Image[3];
    Sprite[] imageList = new Sprite[3];
    int count = 0;
     // 回答数
    public Text TextFrame;
    // 表示する変数
    private int frame;

    // Start is called before the first frame update
    void Start()
    {
       frame = 0; 
    }

    public void AddLogA()
    {
        choiceList[count] = "a";
        count++;
    }
    public void AddLogB()
    {
        choiceList[count] = "b";
        count++;
    }
    public void AddLogC()
    {
        choiceList[count] = "c";
        count++;
    }
    public void AddLogD()
    {
        choiceList[count] = "c";
        count++;
    }
    public void AddLogE()
    {
        choiceList[count] = "d";
        count++;
    }
    public void AddLogF()
    {
        choiceList[count] = "e";
        count++;
    }
    public void AddLogG()
    {
        choiceList[count] = "f";
        count++;
    }
    public void AddLogH()
    {
        choiceList[count] = "h";
        count++;
    }
    //     public void AddLogH(Sprite image)
    // {
    //     choiceList[count] = "h";
    //     // imageList[count] = this.GetComponent<Sprite>();
    //     count++;
    // }

    void Update()
    {
       TextFrame.text = string.Format(choiceList[0]+"\n"+choiceList[1]+"\n"+choiceList[2]);
       
    }
}
