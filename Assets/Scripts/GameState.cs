using UnityEngine.SceneManagement;

public static class GameState
{
    public static readonly int utilSceneCount = 2; // Number of scenes that are not playable
    public static bool isRunning = true;

    public static int GetActiveSceneIndex()
    {
        return SceneManager.GetActiveScene().buildIndex - utilSceneCount;
    }
}
