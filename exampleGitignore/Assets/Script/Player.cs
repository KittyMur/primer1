using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player", order = 52)]
public class Player : ScriptableObject
{
    [SerializeField]
    public int speed;
    [SerializeField]
    private int jumpforce;
    // Start is called before the first frame update
}
