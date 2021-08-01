using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Imageコンポーネントを必要とする
[RequireComponent(typeof(Image))]

// ドラッグとドロップに関するインターフェースを実装する
public class DragAndDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{
    private RectTransform rectTransform;
    private RectTransform parentRectTransform; // 追加...親のRectTransformが欲しいのでフィールドを追加

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        parentRectTransform = rectTransform.parent as RectTransform; // 追加...親のRectTransformを取得(今回の場合はtest2でしょうか)
    }
    // ドラッグ前の位置
    private Vector2 prevPos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置を記憶しておく
        prevPos = rectTransform.anchoredPosition; // 変更...positionではなく、rectTransformのプロパティanchoredPositionを使う
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        // ドラッグ中は位置を更新する
        Vector2 localPosition = GetLocalPosition(eventData.position);
        rectTransform.anchoredPosition = localPosition; // 変更...localPositionではなく、rectTransformのプロパティanchoredPositionを使う
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置に戻す
        rectTransform.anchoredPosition = prevPos; // 変更...positionではなく、rectTransformのプロパティanchoredPositionを使う
        Debug.Log("OnEndDrag");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        var raycastResults = new List<RaycastResult>();


        EventSystem.current.RaycastAll(eventData, raycastResults);

        foreach (var hit in raycastResults)
        {
            // もし DroppableField の上なら、その位置に固定する
            if (hit.gameObject.CompareTag("DroppableField"))
            {
                Vector2 localPosition = GetLocalPosition(eventData.position);
                rectTransform.anchoredPosition = localPosition; // 変更...localPositionではなく、rectTransformのプロパティanchoredPositionを使う
                this.enabled = false;
            }
        }
    }
    //スクリーン座標をワールド座標に変換するメソッド
    private Vector2 GetLocalPosition(Vector2 screenPosition)
    {
        Vector2 result = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTransform, screenPosition, Camera.main, out result); // 変更...自分自身ではなく、親の座標系における座標を求める
        return result;
    }
}
