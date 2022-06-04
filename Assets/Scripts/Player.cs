﻿using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        // TODO Check if canvas not breaks reference
        Debug.Log("Started");
        Text myText = GameObject.Find("CurrentTimeScore").GetComponent<Text>();
        myText.text = "Time Since Loaded : " + Time.timeSinceLevelLoad;
    }
}
