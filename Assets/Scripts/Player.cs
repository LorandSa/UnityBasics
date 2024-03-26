using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    private float horizontalInput;
    private Rigidbody rigidBodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

     void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if space key is pressed down
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rigidBodyComponent.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidBodyComponent.velocity = new Vector3(horizontalInput * jumpForce, rigidBodyComponent.velocity.y, rigidBodyComponent.velocity.z);
    }
}
