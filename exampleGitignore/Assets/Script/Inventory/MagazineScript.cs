using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineScript : MonoBehaviour
{
    public GameObject magazineSlot;
    VerticalLayoutGroup magazineGrid;
    int Count;
    int maxCount = 0;
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
    public void AddSlot()
    {
        Instantiate(magazineSlot, magazineGrid.transform);
        maxCount++;
    }
}
