using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Slot : MonoBehaviour
{
    public InventoryData data;
    public Text slotName;
    public Image slotImage;
    public int mask;
    public RaycastHit2D hit;
    // Start is called before the first frame update

    public virtual void AddData()
    {
        hit = Physics2D.Raycast(transform.position, Vector2.zero, 0f, mask);

        if (hit.collider != null)
        {
            DetectData();
        } 
    }
    public abstract void DetectData();
}
