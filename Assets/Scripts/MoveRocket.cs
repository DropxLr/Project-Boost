using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveRocket : MonoBehaviour
{
    RocketControls controls;
    Vector3 pitch; // used for vertical pitch of rocket

    bool thrustEnabled; // the thrust button is pressed
    bool pitchEnabled; // pitch is active

    Rigidbody rb;
    public float mainThrust = 1000f; //needs tuning with gravity, mass & drag
    public float pitchForce = 0.2f; //use to tune the pitch of the rocket

    AudioSource audioSource;
    public AudioClip engineThrust;
    public ParticleSystem mainBooster;
    public ParticleSystem leftBooster;
    public ParticleSystem rightBooster;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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

        //Pitch - bool
        controls.RocketMovement.Pitch.performed += cntxt => pitchEnabled = true;
        controls.RocketMovement.Pitch.canceled += cntxt => pitchEnabled = false;

    }

    void Update()
    {
        //Pitch
        if (pitchEnabled)
        {
            rb.freezeRotation = true; //freezes rotation (physics) so you can manually rotate
            GetComponent<Transform>().Rotate(Vector3.back * pitch.x * pitchForce);
            rb.freezeRotation = false; //enables rotation again so that physics can apply rotation again
            
            if (Gamepad.current.leftStick.x.ReadValue() < 0 && thrustEnabled) // can this be tidier, bit buggy - needs tuning
            {
                rightBooster.Play();
            }

            else
            {
                rightBooster.Stop();
            }

            if (Gamepad.current.leftStick.x.ReadValue() > 0 && thrustEnabled)
            {
                leftBooster.Play();
            }

            else
            {
                leftBooster.Stop();
            }

        }



        //Thrust
        if (thrustEnabled)
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);

            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(engineThrust);
                mainBooster.Play();
            }
        }
        else
        {
            audioSource.Stop();
            mainBooster.Stop();
        };

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
