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

            case "Fuel":
                Debug.Log("Fuel");
                break;

            case "Finish":
                LoadNextScene();
                break;

            default: // is the result of colliding with anything untagged
                StartCrashSequence();
                break;
        }

        void StartCrashSequence()
        {
            // need to add SFX & particle effect on crash
            GetComponent<MoveRocket>().enabled = false;
            ReloadScene();
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
