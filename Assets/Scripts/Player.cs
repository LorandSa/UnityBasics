using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
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
            GetComponent<Rigidbody>().AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
