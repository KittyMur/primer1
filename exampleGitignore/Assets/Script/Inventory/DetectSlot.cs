using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DetectSlot : MonoBehaviour
{
    InventoryData data;
    private void OnEnable()
    {
        DragandDrop.dropDelegate += Detect;
    }
    private void OnDisable()
    {
        DragandDrop.dropDelegate -= Detect;
    }

    private void Detect()
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
}
