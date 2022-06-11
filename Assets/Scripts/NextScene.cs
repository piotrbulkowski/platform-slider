using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Load()
    {
        int nextSceneIndex = GameManager.Instance.GetActiveSceneIndex() + 1;
        string nextSceneName = "Scene" + nextSceneIndex;


        if (SceneUtility.GetBuildIndexByScenePath(nextSceneName) != -1)
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log($"The scene {nextSceneName} not exists");
            SceneManager.LoadScene("Home");
        }
    }
}
