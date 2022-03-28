using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public float loadDelay = 2f;

    void OnCollisionEnter(Collision other) // behaviour when colliding with gameObjects 
    {
        switch (other.gameObject.tag)
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

        void StartSuccessSequence()
        {
            // need to add SFX & particle effect on success
            GetComponent<MoveRocket>().enabled = false;
            // using the util class to invoke a coroutine to delay the given function
            Util.DelayedCall(this, loadDelay, () =>
            {
                LoadNextScene();
            });
        }

        void StartCrashSequence()
        {
            // need to add SFX & particle effect on crash
            GetComponent<MoveRocket>().enabled = false;
            // using the util class to invoke a coroutine to delay the given function
            Util.DelayedCall(this, loadDelay, () =>
            {
                ReloadScene();
            });
        }

        void ReloadScene() //reloads current scene when colliding with anything untagged in the switch statements above
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }

        void LoadNextScene() //loads next scene in the build index (see build settings)
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
}
