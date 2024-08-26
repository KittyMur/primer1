using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CreateSlots : MonoBehaviour
{
    protected int maxCount = 0;
    protected int Count;
    public abstract void AddSlot();
}
