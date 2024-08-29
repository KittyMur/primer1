using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu(fileName = "New InventoryData", menuName = "Inventory Data", order = 53)]
public class InventoryData : ScriptableObject
{
    [SerializeField]
    private string inventoryName;
    [SerializeField]
    private float inventoryCondition;
    [SerializeField]
    private Sprite inventoryImage;
    [SerializeField]
    private Vector2 inventorySize;

    public string InventoryName
    {
        get
        {
            return inventoryName;
        }
    }
    public float InventoryCondition
    {
        get
        {
            return inventoryCondition;
        }
    }
    public Sprite InventoryImage
    {
        get
        {
            return inventoryImage;
        }
    }
    public Vector2 InventorySize
    {
        get
        {
            return inventorySize;
        }
    }
}
