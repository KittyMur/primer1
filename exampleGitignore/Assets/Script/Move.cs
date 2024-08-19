using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private PlayerInput _input;
    // Start is called before the first frame update
    private void Awake()
    {
        _input = new PlayerInput();
    }
    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }
    // Update is called once per frame
    private void Update()
    {
        Vector2 movedirection = _input.Player.Move.ReadValue<Vector2>();

        Moved(movedirection);

        //float moveInput = Input.GetAxis("Vertical");
        //float rotateInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.forward * moveInput * 50 * Time.deltaTime);
        //Vector3 rot = new Vector3(0f, rotateInput * 180 * Time.deltaTime, 0f);
        //transform.Rotate(rot);
    }
    private void Moved(Vector2 direction)
    {
        float scaedMoveSpeed = 50 * Time.deltaTime;

        Vector3 mdirection = new Vector3(direction.x, 0, direction.y);
        transform.position += mdirection * scaedMoveSpeed;
    }
}
