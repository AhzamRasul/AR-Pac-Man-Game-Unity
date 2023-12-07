using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void QuitGame()
    {
        // This will exit the game when the button is clicked
        Application.Quit();

        // Note: Application.Quit() doesn't work in the Unity Editor, only in a built application.
    }
}
