using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] bool inputEnabled = true;
    private Vector2 movementInput;
    private Vector2 actualVelocity;
    
    [SerializeField] private float movementSpeed = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movementInput = Vector2.zero;
        movementSpeed = 10;
    }

    private void FixedUpdate()
    {
        
        
        rb.linearVelocity = actualVelocity;
        //Debug.Log("actualVelocity: " + actualVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        actualVelocity = new Vector2(movementInput.x * movementSpeed, rb.linearVelocity.y);
    }
    
    public void onMove(InputAction.CallbackContext context)
    {
        Debug.Log("onMove");
        
        if (inputEnabled)
        {
            movementInput = context.ReadValue<Vector2>().normalized;
            Debug.Log(movementInput);
        }
        else
        {
            movementInput = Vector2.zero;
        }
        
        
    }
}
