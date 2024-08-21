using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStat : MonoBehaviour
{
    public Text stats;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Move.movedDelegate += moveText;
        Jump.jumpedDelegate += jumpText;
    }
    private void OnDisable()
    {
        Move.movedDelegate -= moveText;
        Jump.jumpedDelegate -= jumpText;
    }
    private void moveText()
    {
        stats.text = "Player is move";
    }
    private void jumpText()
    {
        stats.text = "Player is jump";
    }
}

