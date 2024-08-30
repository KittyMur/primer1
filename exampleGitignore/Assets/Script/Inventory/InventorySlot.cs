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
        MagazineSlotsScript.dDelegate += AddData;
        DragandDrop.removeDelegate += RemoveSlot;
    }
    private void OnDisable()
    {
        DragandDrop.removeDelegate -= RemoveSlot;
        MagazineSlotsScript.dDelegate -= AddData;
    }
    public override void AddData()
    {
        mask = ~LayerMask.GetMask("magazineSlot");
        base.AddData();
    }
    public override void DetectData()
    {
        if (GetComponentInChildren<MagazineSlotsScript>() != null)
            slotCondition = 1;
        else slotCondition = 0;
    }
    public void RemoveSlot()
    {
        if (slotCondition == 1)
        {
            //Transform slotTransform = GetComponentInChildren<MagazineSlotsScript>().transform;
            //Transform magazineTransform = FindObjectOfType<VerticalLayoutGroup>().transform;

            //slotTransform.SetParent(magazineTransform);

            slotCondition = 0;
        }
    }
}
