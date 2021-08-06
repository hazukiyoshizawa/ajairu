using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TecoPractice01と02画面で次へボタンを押したときのシーン遷移処理
public class MoveManagerTecoPractice : MonoBehaviour
{
    // TecoPractice01Lever.unityで次へボタンが押された
    public void MovePractice01Clear()
    {
        FadeManager.Instance.LoadScene ("Practice01Clear", 1f);
    }

    // TecoPractice02Lever.unityで次へボタンが押された
    public void MovePractice02Clear()
    {
        FadeManager.Instance.LoadScene ("Practice02Clear", 1f);
    }
}
