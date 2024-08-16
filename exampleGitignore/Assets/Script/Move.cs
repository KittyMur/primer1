using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * moveInput * 50 * Time.deltaTime);
        Vector3 rot = new Vector3(0f, rotateInput * 180 * Time.deltaTime, 0f);
        transform.Rotate(rot);
    }
}
