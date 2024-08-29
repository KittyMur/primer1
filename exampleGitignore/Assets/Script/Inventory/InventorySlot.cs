using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;

public class InventorySlot : Slot, IRemovable
{
    public Vector2 slotSize;
    public int slotCondition = 0;

    private void OnEnable()
    {
        transform.localScale = slotSize;
        DragandDrop.dropDelegate += AddData;
        DragandDrop.removeDelegate += RemoveSlot;
    }
    private void OnDisable()
    {
        DragandDrop.dropDelegate -= AddData;
        DragandDrop.removeDelegate += RemoveSlot;
    }
    public override void AddData()
    {
        mask = LayerMask.GetMask("magazineSlot");
        base.AddData();
    }
    public override void DetectData()
    {
        if (GetComponentInChildren<MagazineSlotsScript>() == true)
        {
            slotCondition = 1;
        }
        else slotCondition = 0;
    }
    public void RemoveSlot()
    {
        slotCondition = 0;
    }
}
