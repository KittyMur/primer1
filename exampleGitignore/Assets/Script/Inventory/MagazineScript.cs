using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineScript : CreateSlots
{
    public GameObject magazineSlot;
    VerticalLayoutGroup magazineGrid;
    // Start is called before the first frame update
    private void OnEnable()
    {
        magazineGrid = GetComponentInChildren<VerticalLayoutGroup>();
    }
    void Start()
    {
        Count = 10;
        while (maxCount < Count)
        {
            AddSlot();
        }
    }
    public override void AddSlot()
    {
        Instantiate(magazineSlot, magazineGrid.transform);
        maxCount++;
    }
}
