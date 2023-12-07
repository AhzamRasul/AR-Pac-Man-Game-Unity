using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public Button mainMenuButton;

    private bool gameEnded = false;

    void Start()
    {
        // Ensure the Text component is disabled initially
        gameOverText.gameObject.SetActive(false);

        // Ensure buttons are disabled initially
        restartButton.gameObject.SetActive(false);
        mainMenuButton.gameObject.SetActive(false);

        // Add click listeners to the buttons
        restartButton.onClick.AddListener(RestartGame);
        mainMenuButton.onClick.AddListener(MoveToMainMenu);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the game has already ended
        if (gameEnded)
            return;

        // Check if the collision involves the player and enemy
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.CompareTag("Enemy"))
        {
            // Set the game as ended
            gameEnded = true;

            // Stop the game (you might want to add more logic here)
            Time.timeScale = 0f;

            // Enable the UI and buttons
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            mainMenuButton.gameObject.SetActive(true);
        }
    }

    void RestartGame()
    {
        // Reload the current scene to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void MoveToMainMenu()
    {
        // Load the main menu scene (replace "MainMenu" with your actual main menu scene name)
        SceneManager.LoadScene("Main");
    }
}
