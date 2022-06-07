using TMPro;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            float playerTime = PlayerPrefs.GetFloat("Player Score");
            float elapsedTime = Time.timeSinceLevelLoad;

            Debug.Log($"Finish time {elapsedTime}");

            // First save
            if (playerTime == 0.0)
            {
                PlayerPrefs.SetFloat("Player Score", elapsedTime);
            }

            // Update when better
            if (elapsedTime > 0.0 && elapsedTime < playerTime)
            {
                UpdateBestTimeCounter(elapsedTime);
                PlayerPrefs.SetFloat("Player Score", elapsedTime);
            }

            Debug.Log("Ride finished");
            PauseGame(); // TODO And navigate to the next level
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void UpdateBestTimeCounter(float time)
    {
        GameObject bestScoreObject = GameObject.Find("BestTimeScore");
        TextMeshProUGUI bestScore = bestScoreObject.GetComponent<TextMeshProUGUI>();
        if (bestScore != null)
        {
            bestScore.text = $"Best: {time}s";
        }
    }
}