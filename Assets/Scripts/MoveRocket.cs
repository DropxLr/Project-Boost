using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveRocket : MonoBehaviour
{
    RocketControls controls;
    Vector3 pitch; // used for vertical pitch of rocket

    bool thrustEnabled; // the thrust button is pressed

    Rigidbody rb;
    public float mainThrust = 1000f; //needs tuning with gravity, mass & drag
    public float pitchForce = 1f; //use to tune the pitch of the rocket

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        controls = new RocketControls();

        //Thrust
        controls.RocketMovement.Thrust.performed += cntxt => thrustEnabled = true;
        controls.RocketMovement.Thrust.canceled += cntxt => thrustEnabled = false;

        //Pitch
        controls.RocketMovement.Pitch.performed += cntxt => pitch = cntxt.ReadValue<Vector2>();
        controls.RocketMovement.Pitch.canceled += cntxt => pitch = Vector2.zero;

    }

    // Update is called once per frame
    void Update()
    {
        //Pitch
        GetComponent<Transform>().Rotate(Vector3.forward * pitch.y * pitchForce); // change magic numbers for variables 

        //Thrust
        if (thrustEnabled)
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void OnEnable()
    {
        controls.RocketMovement.Enable();
    }

    void OnDisable()
    {
        controls.RocketMovement.Disable();
    }




}
