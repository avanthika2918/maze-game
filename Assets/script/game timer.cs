using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 180f; // 3 minutes
    public TMP_Text timerText;
    public GameObject gameOverPanel;

    private bool timerRunning = true;

    void Start()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                UpdateTimerDisplay(timeRemaining);
                ShowGameOver();
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void ShowGameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void StopTimer()
    {
        timerRunning = false;
    }
}
