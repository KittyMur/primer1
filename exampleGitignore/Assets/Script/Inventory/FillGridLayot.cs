using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillGridLayot : MonoBehaviour
{
    GridLayout inventoryGrid;
    GameObject[] slots;
    public GameObject slotsPref;
    private int slotCount = 0;
    private void OnEnable()
    {
        inventoryGrid = GetComponent<GridLayout>();
    }
    // Start is called before the first frame update
    void Start()
    {
        AddSlots();
    }

    void AddSlots()
    {
      while (slotCount < 100)
        {
            GameObject randomSlot = slots[Random.Range(0, slots.Length)];

            GameObject newSlot = Instantiate(slotsPref, inventoryGrid.transform);
            newSlot = randomSlot;

            slotCount++;
        }
    }
}
