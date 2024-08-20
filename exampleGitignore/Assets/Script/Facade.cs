using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour 
{
    protected PlayerInput _input;
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
    
}
