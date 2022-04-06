using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CollisionHandler : MonoBehaviour
{
    public float loadDelay = 2f;
    public AudioClip success;
    public AudioClip crashExplosion;
    public ParticleSystem explosionParticles;

    AudioSource audioSource;

    bool isTransitioning = false;
    // bool collisionDisabled = false;

    public bool ignoreCollisions;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other) // behaviour when colliding with gameObjects 
    {
        if (isTransitioning || ignoreCollisions) { return; } //stops triggering if sequence is already running

        switch (other.gameObject.tag) //uses tags to trigger action
        {
            case "Friendly":
                Debug.Log("Friendly");
                break;

            case "Finish":
                StartSuccessSequence();
                break;

            default: // is the result of colliding with anything untagged
                StartCrashSequence();
                break;
        }
    }

    private void StartSuccessSequence() // can trigger crash sound if it slips
    {
        isTransitioning = true;
        audioSource.Stop();
        audioSource.PlayOneShot(success);
        // need to amend SFX above & add particle effect on success
        GetComponent<MoveRocket>().enabled = false;
        // using the util class to invoke a coroutine to delay the given function
        Util.DelayedCall(this, loadDelay, () => { LoadNextScene(); });
    }

    private void StartCrashSequence()
    {
        isTransitioning = true;
        audioSource.Stop();
        audioSource.PlayOneShot(crashExplosion);
        explosionParticles.Play();

        GetComponent<MoveRocket>().enabled = false;
        // using the util class to invoke a coroutine to delay the given function
        Util.DelayedCall(this, loadDelay, () => { ReloadScene(); });
    }

    private void ReloadScene() //reloads current scene when colliding with anything untagged in the switch statements above
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNextScene() //loads next scene in the build index (see build settings)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }

}
