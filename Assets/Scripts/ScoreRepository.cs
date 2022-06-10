using UnityEngine;

public static class ScoreRepository
{
    public static float GetScore(int SceneIndex)
    {
        return PlayerPrefs.GetFloat(GetScoreName(SceneIndex), 0f);
    }

    public static void SetScore(int SceneIndex, float Score)
    {
        PlayerPrefs.SetFloat(GetScoreName(SceneIndex), Score);
    }

    private static string GetScoreName(int SceneIndex)
    {
        return "Score" + SceneIndex;
    }
}
