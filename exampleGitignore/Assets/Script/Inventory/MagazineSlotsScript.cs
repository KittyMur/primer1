using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineSlotsScript : MonoBehaviour, Slot
{
    public InventoryData data;
    public Text slotName;
    public Image slotImage;
    private void OnEnable()
    {
        DragandDrop.dropDelegate += RemoveData;
    }
    private void OnDisable()
    {
        DragandDrop.dropDelegate += RemoveData;
    }
    // Start is called before the first frame update
    void Start()
    {
        AddData();
    }

    // Update is called once per frame
    public void AddData()
    {
        slotName.text = data.InventoryName;
        slotImage.sprite = data.InventoryImage;
        transform.localScale = data.InventorySize;
    }

    public void RemoveData()
    {

    }
}
