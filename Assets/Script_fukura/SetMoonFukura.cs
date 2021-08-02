using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Drawing;



public class SetMoonFukura : MonoBehaviour
{
    public Image image;
    // int count = 0;
 
 
    // Use this for initialization
    void Start () {
 
    }
 
    // Update is called once per frame
    public void setMoon(Sprite sprite) {
        // sprite = Resources.Load<Sprite>("bag2");
        image = this.GetComponent<Image>();
        image.sprite = sprite;
    }
    // // スプライト画像格納用の配列
    // Sprite[] sprites = new Sprite[3];
    // public void setMoon(Sprite sprite)
    // {
    //     sprites[0] = sprite;
    //     count++;

    // // 空のゲームオブジェクトを作成する
    // GameObject obj = new GameObject();
    // }

    // public void displayMoon()
    // {

    // // 空のゲームオブジェクトを作成する
    // GameObject obj = new GameObject();

    // // とりあえずスプライトの数だけループ
    // for(int i=0;i < sprites.Length;i++) {

    // // 空のゲームオブジェクトを生成する、横に並べてみた
    // GameObject go = Instantiate(obj, new Vector3(i,0,0),Quaternion.identity) as GameObject;

    // // 生成したゲームオブジェクトはTransformのみなのでSpriteRendererをスクリプトから追加、スプライトに配列の画像を代入
    // go.AddComponent<SpriteRenderer>().sprite = sprites[i];
    // }

    // // 空のゲームオブジェクトが気に入らないのでとりあえず消しとく
    // Destroy(obj);
    // }
}
