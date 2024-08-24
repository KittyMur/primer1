using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    Vector2 oldPosition;
    private void OnEnable()
    {
        oldPosition = transform.localPosition;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = oldPosition;
    }
}
