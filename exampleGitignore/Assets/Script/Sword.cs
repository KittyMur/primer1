using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : Facade
{
    [SerializeField]
    private SwordData swordData;

    public LayerMask mask;
    public virtual void swordDiscovery()
    {

    }
}
