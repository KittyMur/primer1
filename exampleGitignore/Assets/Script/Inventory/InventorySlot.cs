using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, Slot
{
    public Vector2 slotSize;
    private void OnEnable()
    {
        transform.localScale = slotSize;
        DragandDrop.dropDelegate += AddData;
        DragandDrop.dropRemove += RemoveData;
    }
    private void OnDisable()
    {
        DragandDrop.dropDelegate -= AddData;
        DragandDrop.dropRemove += RemoveData;
    }
    public void AddData()
    {
        int mask = LayerMask.GetMask("inventorySlot");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, 0f, mask);

        if (hit.collider != null)
        {
            Transform data = hit.collider.transform;
            data.SetParent(transform);
            data.transform.position = transform.position;
        }
    }

    public void RemoveData()
    {
        Debug.Log("111");
    }
    
}
