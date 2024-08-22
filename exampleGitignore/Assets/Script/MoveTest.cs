using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Move move = new Move();
        move.Moved();

        MoveSlow moveSlow = new MoveSlow();
        moveSlow.Moved();

        MoveSpeed moveSpeed = new MoveSpeed();
        moveSpeed.Moved();
    }
}
