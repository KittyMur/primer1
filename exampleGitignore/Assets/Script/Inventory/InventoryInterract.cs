using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class InventoryInterract : MonoBehaviour
{
    public static event Action removeDelegate;
    // Start is called before the first frame update
    public void OnClick()
    {
        removeDelegate?.Invoke();
    }
}
