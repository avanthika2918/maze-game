using UnityEngine;

public class DestinationTrigger : MonoBehaviour
{
    public GameTimer gameTimer;
    public GameObject winPanel; // Optional win panel

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameTimer.StopTimer();

            if (winPanel != null)
            {
                winPanel.SetActive(true);
            }

            Time.timeScale = 0f; // Stop game when player wins
        }
    }
}
