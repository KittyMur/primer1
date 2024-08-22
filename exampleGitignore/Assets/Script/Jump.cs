using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : Facade
{
    public float raycastDistance = 1.1f;
    public Rigidbody rb;
    public bool isGrounded;
    public static event Action jumpedDelegate;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        _input.Player.Jump.performed += Jumped;
        _input.Player.Jump.Enable();
    }
    private void OnDisable()
    {
        _input.Player.Jump.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        isGrounded = CheckGrounded();

    }
    bool CheckGrounded()
    {
        RaycastHit hit;
        int mask = 1 << LayerMask.NameToLayer("ground");
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance, mask))
        {
            return true; // Персонаж стоит на земле
        }
        else
        {
            return false; // Персонаж не стоит на земле
        }
    }

    private void Jumped(InputAction.CallbackContext obj)
    {
        if (isGrounded)
        {
            rb.velocity = new Vector3(0, player.Jumpforce, 0);
            jumpedDelegate?.Invoke();
        }
    }

}
