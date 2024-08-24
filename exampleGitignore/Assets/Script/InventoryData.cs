using System.Collections;
using System.Collections.Generic;
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
}
