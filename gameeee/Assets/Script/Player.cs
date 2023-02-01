using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   

    private Rigidbody rb;

    private bool jumpKeyWasPressed;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * 100);
        }

        horizontalInput = Input.GetAxis("Horizontal");


    }

    private void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

        //GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);
    }

}