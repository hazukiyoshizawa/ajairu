using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler
{
    //ドロップ時に呼ばれるメソッド//
    public void OnDrop(PointerEventData data){
        //ドロップ時にドロップ先のオブジェクト名をコンソールに表示//
        Debug.Log(gameObject.name);

        //ドロップ時に、DragObjスクリプトがコンポーネントされているオブジェクトの情報を入れる//
        DragObj dragObj = data.pointerDrag.GetComponent<DragObj>();
        
        //ドロップ時に、DragObjスクリプトがコンポーネントされているオブジェクトがあるとき//
        if(dragObj != null){

            //ドロップエリアの情報ををparentTransformに格納//
            //thisはDropAreaクラスを指す//
            dragObj.parentTransform = this.transform;

            //コンソールにドロップ先のオブジェクト名とドロップするオブジェクト名を表示//
            Debug.Log(gameObject.name+"に"+data.pointerDrag.name+"をドロップ");
        }       
    }
}
