﻿using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;

    void Start()
    {
        GameState.isRunning = true;
        float bestResult = ScoreRepository.GetScore(GameState.GetActiveSceneIndex());

        GameObject bestScoreObject = GameObject.Find("BestTimeScore");
        TextMeshProUGUI bestScore = bestScoreObject.GetComponent<TextMeshProUGUI>();
        if (bestScore != null)
        {
            bestScore.text = $"Best: {bestResult}s";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        GameObject bestScoreObject = GameObject.Find("CurrentTimeScore");
        TextMeshProUGUI currentScore = bestScoreObject.GetComponent<TextMeshProUGUI>();
        if (currentScore != null && GameState.isRunning)
        {
            currentScore.text = $"Current: {Time.timeSinceLevelLoad}s";
        }
    }
}
