using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public string targetScene;

    public void ChangeScene()
    {
        // Check if the target scene name is not empty
        if (!string.IsNullOrEmpty(targetScene))
        {
            // Load the target scene
            SceneManager.LoadScene(targetScene);
        }
        else
        {
            Debug.LogError("Target scene name is not specified!");
        }
    }
}
