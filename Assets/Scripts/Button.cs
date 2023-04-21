using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{


    private bool _isPressed;
    private Rigidbody rb;

    public UnityEvent onPressed, onReleased;

    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isPressed && rb.velocity.magnitude > 0.001)
        {
            Pressed();
        }
        else if (_isPressed && rb.velocity.magnitude == 0)
        {
            Released();
        }
        
    }

    private void Pressed()
    {
        _isPressed = true;
        onPressed.Invoke();
        Debug.Log("Pressed");
    }

    private void Released()
    {
        _isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");
    }
}
