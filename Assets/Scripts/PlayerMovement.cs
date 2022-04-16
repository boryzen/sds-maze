using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float movementSpeed;
    
    public float groundDrag;
    [Header("Ground Check")]

    public float playerHight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float veriticalInput;

    Vector3 moveDirection;

    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHight * 0.5f + 0.2f, whatIsGround);

        MyInput();

        if(grounded)
            rb.drag = groundDrag;
        else
        {
            rb.drag = 0f;
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        veriticalInput = Input.GetAxisRaw("Vertical");

    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * veriticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * movementSpeed * 10f, ForceMode.Force);
    }
}
