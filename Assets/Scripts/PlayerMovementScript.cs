using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] bool inputEnabled = true;
    private Vector2 movementInput;
    private Vector2 actualVelocity;
    
    [SerializeField] private float movementSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movementInput = Vector2.zero;
        movementSpeed = 25.0f;
    }

    private void FixedUpdate()
    {
        actualVelocity = new Vector2(movementInput.x * movementSpeed, 0) * Time.deltaTime;
        actualVelocity = Vector2.ClampMagnitude(actualVelocity, movementSpeed * 5);
        
        rb.linearVelocity += actualVelocity;
        //Debug.Log("actualVelocity: " + actualVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        
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
