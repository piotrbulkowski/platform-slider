using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class ScoreManager : MonoBehaviour
    {
        public TextMeshProUGUI CurrentScoreComponent;
        public TextMeshProUGUI BestScoreComponent;

        public void UpdateCurrentTimeScore()
        {
            if (GameManager.Instance.IsGameRunning())
            {
                CurrentScoreComponent.text = $"Current:{Time.timeSinceLevelLoad:0.00}";
            }
        }

        public void UpdateBestTimeScore()
        {
            var bestTimeResult = ScoreRepository.GetScore(GameManager.Instance.GetActiveSceneIndex());
            BestScoreComponent.text = $"Best:{bestTimeResult:0.00}";
        }
    }
}