using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static event Action dropDelegate;
    public Vector2 oldPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        oldPosition = transform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dropDelegate?.Invoke();
    }
    void OnMouseDown()
    {

    }
}
