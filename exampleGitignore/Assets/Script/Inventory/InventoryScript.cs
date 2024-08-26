using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : CreateSlots
{
    public GameObject inventorySlot;
    GridLayoutGroup inventoryGrid;
    // Start is called before the first frame update
    private void OnEnable()
    {
        inventoryGrid = GetComponent<GridLayoutGroup>();
    }
    void Start()
    {
        Count = 100;
        while (maxCount < Count)
        {
            AddSlot();
        }
    }
    public override void AddSlot()
    {
        Instantiate(inventorySlot, inventoryGrid.transform);
        maxCount++;
    }
}
