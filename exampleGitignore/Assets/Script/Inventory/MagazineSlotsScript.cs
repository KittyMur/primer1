using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MagazineSlotsScript : Slot, IRemovable
{
    Transform parent;
    GameObject slot;
    public static event Action dDelegate;
    private void OnEnable()
    {
        DragandDrop.dropDelegate += AddData;
        DragandDrop.dropDelegate += RemoveSlot;
        DragandDrop.removeDelegate += SetParent;
    }
    private void OnDisable()
    {
        DragandDrop.dropDelegate -= AddData;
        DragandDrop.dropDelegate -= RemoveSlot;
        DragandDrop.removeDelegate -= SetParent;
    }
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
        slotName.text = data.InventoryName;
        slotImage.sprite = data.InventoryImage;
        transform.localScale = data.InventorySize;
    }

    // Update is called once per frame
    public override void AddData()
    {
        mask = LayerMask.GetMask("inventorySlot");
        base.AddData();
    }
    public override void DetectData()
    {
        slot = hit.collider.gameObject;
        Vector2 slotSize = slot.GetComponent<InventorySlot>().slotSize;
        float slotCondition = slot.GetComponent<InventorySlot>().slotCondition;
        Transform slotTransform = hit.collider.transform;

        if (slotCondition == 0 && slotSize == data.InventorySize)
        {
            transform.SetParent(slotTransform);
            transform.position = slotTransform.transform.position;
            GetComponent<DragandDrop>().change = false;
            dDelegate?.Invoke();
        }  
    }
    public void RemoveSlot()
    {
        if (hit.collider == null)
        GetComponent<DragandDrop>().change = true;
    }

    public void SetParent()
    {
        transform.SetParent(parent);
    }
}
