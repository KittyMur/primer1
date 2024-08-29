using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineScript : MonoBehaviour
{
    public MagazineSlotsScript[] magazineSlots;
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
        magazineSlots = Resources.FindObjectsOfTypeAll<MagazineSlotsScript>();
        Count = 5;
        while (maxCount < Count)
        {
            AddSlots();
        }
    }
    public void AddSlots()
    {
        int indezDataList = Random.Range(0, magazineSlots.Length);
        Instantiate(magazineSlots[indezDataList], magazineGrid.transform);
        maxCount++;
    }
}
