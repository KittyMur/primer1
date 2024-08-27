using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineSlotsScript : MonoBehaviour, Slot
{
    public InventoryData[] datas;
    public Text slotName;
    private float slotCondition;
    public Image slotImage;
    private Vector2 slotSize;
    private void OnEnable()
    {
        DragandDrop.dropRemove += RemoveData;
    }
    private void OnDisable()
    {
        DragandDrop.dropRemove += RemoveData;
    }
    // Start is called before the first frame update
    void Start()
    {
        AddData();
    }

    // Update is called once per frame
    public void AddData()
    {
        int indezDataList = Random.Range(0, datas.Length);
        slotName.text = datas[indezDataList].InventoryName;
        slotImage.sprite = datas[indezDataList].InventoryImage;
        transform.localScale = datas[indezDataList].InventorySize;
    }

    public void RemoveData()
    {
        Debug.Log("111");
    }
}
