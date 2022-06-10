using Assets.Scripts;
using TMPro;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.Instance.Stop();

            float playerTime = ScoreRepository.GetScore(GameManager.Instance.GetActiveSceneIndex());
            float elapsedTime = Time.timeSinceLevelLoad;

            Debug.Log($"Finish time {elapsedTime}");

            // First save
            if (playerTime == 0f)
            {
                ScoreRepository.SetScore(GameManager.Instance.GetActiveSceneIndex(), elapsedTime);
                UpdateBestTimeCounter(elapsedTime);
            }

            // Update when better
            if (elapsedTime > 0.0 && elapsedTime < playerTime)
            {
                UpdateBestTimeCounter(elapsedTime);
                ScoreRepository.SetScore(GameManager.Instance.GetActiveSceneIndex(), elapsedTime);
            }

            Debug.Log("Ride finished");

            GameObject finishPanel = FindInActiveObjectByName("FinishPanel");
            finishPanel.SetActive(true);
        }
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

    GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].name == name)
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }
}
