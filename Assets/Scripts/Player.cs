using Assets.Scripts;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private ScoreManager _scoreManager;

    public void Awake()
    {
        _scoreManager = new();
    }
    public void Start()
    {
        GameState.isRunning = true;

        _scoreManager.UpdateBestTimeScore();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
        _scoreManager.UpdateCurrentTimeScore();
    }
}
