using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSlot : DragandDrop
{
    bool isSlot;
    private void OnEnable()
    {
        dropDelegate += Detect;
    }
    private void OnDisable()
    {
        dropDelegate -= Detect;
    }

    private void Detect()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        int mask = 1 << LayerMask.NameToLayer("inventorySlot");

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask, QueryTriggerInteraction.Ignore))
        {
            isSlot = true;
            Debug.Log("111");
        }
        else
        {
            isSlot = false;
        }
    }

    public override void oldPos()
    {
        if (isSlot)
            Debug.Log("111");

        if (isSlot == false)
            base.oldPos();
    }
}
