using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineScript : MonoBehaviour
{
    public GameObject magazineSlot;
    GridLayoutGroup magazineGrid;
    int maxCount = 0;
    // Start is called before the first frame update
    private void OnEnable()
    {
        magazineGrid = GetComponentInChildren<GridLayoutGroup>();
    }
    void Start()
    {
        while (maxCount < magazineGrid.constraintCount)
        {
            AddSlot();
        }
    }

    void AddSlot()
    {
        Instantiate(magazineSlot, magazineGrid.transform);
        maxCount++;
    }
}
