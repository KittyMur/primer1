using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public static event Action dropDelegate;
    protected Vector2 oldPosition;

    void Start()
    {
        oldPosition = transform.localPosition;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        oldPos();
        dropDelegate?.Invoke();
    }

    public virtual void oldPos()
    {
        transform.localPosition = oldPosition;
    }
}
