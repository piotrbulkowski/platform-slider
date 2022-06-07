using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RefreshScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        ResumeGame();
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
