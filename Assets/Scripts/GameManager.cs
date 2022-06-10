using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public static GameState GameState { get; private set; }

        public ScoreManager ScoreManager;

        private void Awake()
        {
            Instance = this;
            GameState = GameState.Create();
        }

        public void Begin()
        {
            GameState.isRunning = true;

            ScoreManager.UpdateBestTimeScore();
        }

        public void Stop()
        {
            GameState.isRunning = false;
        }

        public void Update()
        {
            if (IsGameRunning())
            {
                ScoreManager.UpdateCurrentTimeScore();
            }
            
        }

        public int GetActiveSceneIndex()
        {
            return SceneManager.GetActiveScene().buildIndex - GameState.utilSceneCount;
        }

        public bool IsGameRunning()
            => GameState.isRunning;
    }
}
