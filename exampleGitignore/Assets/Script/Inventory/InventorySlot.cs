using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, Slot
{
    public Vector2 slotSize;
    public InventoryData data;
    Vector2 oldPosition;
    GameObject slot;

    public Text slotName;
    public Image slotImage;
    private void OnEnable()
    {
        transform.localScale = slotSize;
        DragandDrop.dropDelegate += AddData;
    }
    private void OnDisable()
    {
        DragandDrop.dropDelegate -= AddData;
    }
    public void AddData()
    {
        int mask = LayerMask.GetMask("inventorySlot");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, 0f, mask);

        if (hit.collider != null)
        {
            slot = hit.collider.gameObject;
            data = slot.GetComponent<MagazineSlotsScript>().data;

            Transform data1 = hit.collider.transform;

            if (slotSize == data.InventorySize)
            {
                data1.SetParent(transform);
                data1.transform.position = transform.position;

                //slotImage.enabled = true;
                //slotName.text = data.InventoryName;
                //slotImage.sprite = data.InventoryImage;

                //slot.GetComponent<MagazineSlotsScript>().data = null;
            }
            else
            {
                data = null;
                RemoveData();
            }

        }
    }
    public void RemoveData()
    {
        oldPosition = slot.GetComponent<DragandDrop>().oldPosition;
        slot.transform.position = oldPosition;
    }
}
