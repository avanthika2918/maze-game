using UnityEngine;

public class DestinationTrigger : MonoBehaviour
{
    public GameTimer gameTimer;
    public GameObject winPanel;

    private bool hasWon = false;

    void Start()
    {
        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered!");

        if (!hasWon && other.CompareTag("Player"))
        {
            hasWon = true;

            Debug.Log("Player reached destination!");

            if (gameTimer != null)
            {
                gameTimer.StopTimer();
            }

            if (winPanel != null)
            {
                winPanel.SetActive(true);
            }

            Time.timeScale = 0f;
        }
    }

}
