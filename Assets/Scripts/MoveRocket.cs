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
    bool debugCollisionDisabled; // debug mode - collision disabled

    bool collisionDisabled = false;

    Rigidbody rb;
    public float mainThrust = 1000f; //needs tuning with gravity, mass & drag
    public float pitchForce = 0.2f; //use to tune the pitch of the rocket

    AudioSource audioSource;
    public AudioClip engineThrust;
    public ParticleSystem mainBooster;
    public ParticleSystem leftBooster;
    public ParticleSystem rightBooster;

    public CollisionHandler collisionHandler;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Awake()
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

        //Debug Next Level Enabled
        controls.RocketMovement.Debug_NextLevel.performed += OnNextLevel;

        //Debug Collision Disabled
        controls.RocketMovement.Debug_CollisionDisabled.performed += OnCollisionDisable;
    }

    void Update()
    {
        processPitch();
        fireMainThruster();
        fireSideBoosters();
    }

    void OnNextLevel(InputAction.CallbackContext cntxt)
    {
        collisionHandler.LoadNextScene();
    }

    void OnCollisionDisable(InputAction.CallbackContext cntxtr)
    {
        collisionHandler.ignoreCollisions = !collisionHandler.ignoreCollisions;
    }


    void processPitch()
    {
        if (pitchEnabled)
        {
            rb.freezeRotation = true; //freezes rotation (physics) so you can manually rotate
            GetComponent<Transform>().Rotate(Vector3.back * pitch.x * pitchForce);
            rb.freezeRotation = false; //enables rotation again so that physics can apply rotation again
        }
    }

    void fireMainThruster()
    {
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

    void fireSideBoosters()
    {
        if (Gamepad.current.leftStick.x.ReadValue() < 0 || Keyboard.current.aKey.isPressed)
        {
            if (!rightBooster.isPlaying)
            {
                rightBooster.Play();
            }
        }
        else
        {
            rightBooster.Stop();
        }

        if (Gamepad.current.leftStick.x.ReadValue() > 0 || Keyboard.current.dKey.isPressed)
        {
            if (!leftBooster.isPlaying)
            {
                leftBooster.Play();
            }
        }
        else
        {
            leftBooster.Stop();
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
