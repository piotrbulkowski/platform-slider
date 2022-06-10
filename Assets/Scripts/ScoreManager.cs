using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class ScoreManager : MonoBehaviour
    {
        private readonly TextMeshProUGUI _currentScoreComponent;

        public ScoreManager()
        {
            var bestScoreObject = GameObject.Find("CurrentTimeScore");
            _currentScoreComponent = bestScoreObject.GetComponent<TextMeshProUGUI>();

            if (_currentScoreComponent is null)
            {
                throw new InvalidOperationException("Could not find current time score component");
            }
        }
        /// <summary>
        /// Updated CurrentTimeScore text with timeSinceLevelLoad with 2 decimal places precision
        /// </summary>
        public void UpdateCurrentTimeScore()
        {
            if (GameState.isRunning)
            {
                _currentScoreComponent.text = $"Current:{Time.timeSinceLevelLoad:0.00}";
            }
        }

        public void UpdateBestTimeScore()
        {
            var bestTimeResult = ScoreRepository.GetScore(GameState.GetActiveSceneIndex());
            var bestScoreObject = GameObject.Find("BestTimeScore");
            var bestScoreComponent = bestScoreObject.GetComponent<TextMeshProUGUI>();
            
            if (bestScoreComponent != null)
            {
                bestScoreComponent.text = $"Best:{bestTimeResult:0.00}";
            }
        }
    }
}