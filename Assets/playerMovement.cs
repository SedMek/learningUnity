using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float forwardStep = 50f;
    public float sideStep = 20f;
    public Rigidbody rb;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardStep * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardStep * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, sideStep * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideStep * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideStep * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
