using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice01Lever : MonoBehaviour
{
    //てこのオブジェクト
    GameObject lever;
    //右側の重りのオブジェクト
    GameObject rightWeight;
    //右側の重りの移動先座標
    Vector3 rightWeightTargetPosition;
    //月の重りのオブジェクト
    GameObject moonItem;
    //月の重りの移動先座標
    Vector3 moonItemTargetPosition;
    //前回の月の親オブジェクト名
    // string preMoonParentName;
    
    private void Start()
    {
        //てこのオブジェクトを取得
        lever = GameObject.Find("Lever");
        //右側の重りのオブジェクトを取得
        rightWeight = GameObject.Find("Weight01");
        //月の重りのオブジェクトを取得
        moonItem = GameObject.Find("MoonItem");
        //初期状態は月の親オブジェクト名は空に設定
        // preMoonParentName = "";
    }

    public void Update()
    {
        //現在の月の重りの親オブジェクト名を取得(Leverのメモリ単位)
        string moonParentName = moonItem.transform.parent.name;

        float targetZ = 0f;
        switch (moonParentName)
        {
            case "Panel01":
                targetZ = 340f; 
                break;
            case "Panel02":
                targetZ = 345f; 
                break;
            case "Panel03":
                targetZ = 350f; 
                break;
            case "Panel04":
                targetZ = 360f; 
                break;
            case "Panel05":
                targetZ = 370f; 
                break;
            case "Panel06":
                targetZ = 375f; 
                break;
            case "Panel07":
                targetZ = 380f; 
                break;
            default:
                targetZ = 320f;
                break;
        }
        //てこオブジェクトのオイラー角を取得
        Vector3 leverRotationAngles = lever.transform.rotation.eulerAngles;

        //現在のてこの角度から目標の角度までのangleを計算
        float leverAngle = Mathf.LerpAngle(leverRotationAngles.z, targetZ, 0.05f);
        //てこを回転させる
        lever.transform.eulerAngles = new Vector3(0, 0, leverAngle);

        //右側の重りの移動先オブジェクトを取得
        rightWeightTargetPosition = GameObject.Find("RightPoint04").transform.position;
        //右側の重りの位置を変更
        rightWeight.transform.position = Vector3.MoveTowards(rightWeight.transform.position, rightWeightTargetPosition, 1f);
        
        // //現在の月の親オブジェクトの移動先を取得
        // moonItemTargetPosition = GameObject.Find(moonParentName).transform.position;
        // //月の吊るす位置が変わった
        // if(moonParentName != preMoonParentName)
        // {
        //     //月をその位置に瞬間移動
        //     moonItem.transform.position = moonItemTargetPosition;
        // }

        // //月をてこの動きに合わせて滑らかに移動
        // moonItem.transform.position = Vector3.MoveTowards(moonItem.transform.position, moonItemTargetPosition, 1f);

    }
}
