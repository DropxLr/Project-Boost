using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour //original script from the GameDev.TV course
{
    Rigidbody rb;
    public float mainThrust = 1000f;
    public float rotateThrust = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

 
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotateThrust);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotateThrust);
        }

    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; //freezes rotation (physics) so you can manually rotate
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; //enables rotation again so that physics can apply rotation again
    }
}
