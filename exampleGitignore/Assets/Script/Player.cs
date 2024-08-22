using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player", order = 52)]
public class Player : ScriptableObject
{
    [SerializeField]
    private int speed;
    [SerializeField]
    private int jumpforce;
    // Start is called before the first frame update
    public int Speed
    {
        get
        {
            return speed;
        }
    }
    public int Jumpforce
    {
        get
        {
            return jumpforce;
        }
    }
}
