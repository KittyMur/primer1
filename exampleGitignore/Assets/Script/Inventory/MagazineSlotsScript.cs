using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineSlotsScript : MagazineScript
{
    public InventoryData[] datas;
    public Text slotName;
    private float slotCondition;
    public Image slotImage;
    private Vector2 slotSize;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomData();
    }

    // Update is called once per frame
    private void SetRandomData()
    {
        int indezDataList = Random.Range(0, datas.Length);
        slotName.text = datas[indezDataList].InventoryName;
        slotImage.sprite = datas[indezDataList].InventoryImage;
    }
}
