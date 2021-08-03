using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObj : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform parentTransform;

    //ドラッグ開始時の座標
    public Vector3 startPosition;

    //ドラッグ開始時に呼ばれるメソッド//
    public void OnBeginDrag(PointerEventData data){
        //ドラッグ開始時にコンソールに表示//
        Debug.Log("OnBeginDrag");
        
        //オブジェクトのコンポーネント「CanvasGroup」のblocksRaycastsを無効化する//
        GetComponent<CanvasGroup>().blocksRaycasts = false;

        //現在の親オブジェクトの情報をparentTransformに格納//
        parentTransform = transform.parent;

        //ドラッグ開始時の座標を取得
        startPosition = transform.position;

        //親オブジェクトをもう一つ上の親に変換//
        // transform.SetParent(transform.parent.parent);

    }

    //ドラッグ中に呼ばれるメソッド//
    public void OnDrag(PointerEventData data){
        /*Vector2 localPos = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(GetComponent<RectTransform>(),
         data.position, Camera.main, out localPos);*/
         
        /*Vector3 data_3D = Camera.main.ScreenToWorldPoint(data.position);
        data_3D = Vector3 pos = transform.position;
        pos = data_3D;*/
        
        // Vector3 data_3D = Camera.main.WorldToScreenPoint((Vector3)data.delta);
        // transform.localPosition = data_3D;

        //オブジェクトの位置にカーソルの位置情報を代入//
        // transform.position = data.position;
        // Debug.Log((Vector3)data.delta);
        // transform.position += Vector3.Scale(new Vector3(0.2f, 0.2f, 0.2f), (Vector3)data.delta);
        
        //ドラッグしたオブジェクトのワールド座標からスクリーン座標を取得
        Vector3 objectPoint
            = Camera.main.WorldToScreenPoint(transform.position);
 
        //Cubeの現在位置(マウス位置)を、pointScreenに格納
        Vector3 pointScreen
            = new Vector3(Input.mousePosition.x,
                          Input.mousePosition.y,
                          objectPoint.z);
        
        //Cubeの現在位置を、スクリーン座標からワールド座標に変換して、pointWorldに格納
        Vector3 pointWorld = Camera.main.ScreenToWorldPoint(pointScreen);
        pointWorld.z = transform.position.z;
        
        //Cubeの位置を、pointWorldにする
        transform.position = pointWorld;        
    }

    //ドラッグ終了時に呼ばれるメソッド//
    public void OnEndDrag(PointerEventData data){
        //ドラッグ終了時にコンソールに表示//
        Debug.Log("OnEndDrag");

         //ドラッグ終了時に開始時の座標に設定
        //※正しくPanelオブジェクトにドラッグされていない場合は、ここで元の位置に戻す
        transform.position = startPosition;
        
        //現在の親オブジェクトの情報をparentTransformに格納//
        transform.SetParent(parentTransform);
        
        //オブジェクトのコンポーネント「CanvasGroup」のblocksRaycastsを有効にする//
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }   
}