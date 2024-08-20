using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : Facade
{
    Vector2 movedirection;
    protected int speed = 50;
    // Update is called once per frame
    private void Update()
    {
        movedirection = _input.Player.Move.ReadValue<Vector2>();

        Moved();
    }
    public virtual void Moved()
    {
        float scaedMoveSpeed = speed * Time.deltaTime;

        Vector3 mdirection = new Vector3(movedirection.x, 0, movedirection.y);
        transform.position += mdirection * scaedMoveSpeed;
    }
}
