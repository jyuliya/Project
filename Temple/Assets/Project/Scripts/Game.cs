﻿using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
    public float timeRemaining = 10;   //Pre-earned time
    float timeExtension = 3f;   //time to extend by on collecting powerup
    float timeDeduction = 2f;   //time to reduce, on collecting the snag
    float totalTimeElapsed = 0;
    float score = 0f;      //total score
    public bool isGameOver = false;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;  // set the time scale to 1, to start the game world. This is needed if you restart the game from the game over menu
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)     //check if isGameOver is true
            return;      //move out of the function

        totalTimeElapsed += Time.deltaTime;
        timeRemaining -= Time.deltaTime; //decrement the time remaining by 1 sec every update
        if (timeRemaining <= 0)
        {
            isGameOver = true;    // set the isGameOver flag to true if timeRemaining is zero
        }
    }

    public void CoinCollected()
    {
        float Rand = Random.Range(1, 10);
        if (Rand > 5)
        {
            timeRemaining += 1;
        } else
        {
            timeRemaining -= 1;
        }
        score += 10;
    }

    public void obtacleTouch()
    {
        isGameOver = true;
    }

    void OnGUI()
    {
        //check if game is not over, if so, display the score and the time left
        if (!isGameOver)
        {
            GUI.Label(new Rect(10, 10, Screen.width / 5, Screen.height / 6), "TIME LEFT: " + ((int)timeRemaining).ToString());
            GUI.Label(new Rect(Screen.width - (Screen.width / 6), 10, Screen.width / 6, Screen.height / 6), "SCORE: " + ((int)score).ToString());
        }
        //if game over, display game over menu with score
        else
        {
            Time.timeScale = 0; //set the timescale to zero so as to stop the game world

            //display the final score
            GUI.Box(new Rect(Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), "GAME OVER\nYOUR SCORE: " + (int)score);

            //restart the game on click
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "RESTART"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }

            //load the main menu, which as of now has not been created
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + 2 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "MAIN MENU"))
            {
                Application.LoadLevel(1);
            }

            //exit the game
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + 3 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "EXIT GAME"))
            {
                Application.Quit();
            }
        }
    }
}
