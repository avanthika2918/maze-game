using UnityEngine;
using UnityEngine.SceneManagement; // needed to reload scenes

public class GameOverMenu : MonoBehaviour
{
    // Call this function from the Restart button
    public void RestartGame()
    {
        // Reload the currently active scene
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}