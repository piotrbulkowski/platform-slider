using UnityEngine.SceneManagement;

public class GameState
{
    public int utilSceneCount { get; private set; } // Number of scenes that are not playable
    public bool isRunning { get; set; }

    private GameState(int utilSceneCount)
    {
        this.utilSceneCount = utilSceneCount;
        isRunning = false;
    }

    public static GameState Create()
    {
        return new GameState(utilSceneCount: 2);
    }
}
