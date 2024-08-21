using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : Facade
{
    public static event Action movedDelegate;
    public InputAction movement;
    Vector2 movedirection;
    protected int speed = 50;
    // Update is called once per frame
    private void OnEnable()
    {
        movement = _input.Player.Move;
        movement.Enable();
    }
    private void FixedUpdate()
    {
        movedirection = movement.ReadValue<Vector2>();
        Moved();
    }
    public virtual void Moved()
    {
        float scaedMoveSpeed = speed * Time.deltaTime;

        Vector3 mdirection = new Vector3(movedirection.x, 0, movedirection.y);
        transform.position += mdirection * scaedMoveSpeed;

        if (movement.WasPressedThisFrame())
            movedDelegate?.Invoke();
    }
}
