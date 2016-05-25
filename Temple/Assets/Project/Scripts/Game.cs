using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
    public float timeRemaining = 10;   
    float timeExtension = 3f;   
    float timeDeduction = 2f;   
    float totalTimeElapsed = 0;
    float score = 0f;      
    public bool isGameOver = false;
    private bool start = true;
    
    void Start()
    {
        Time.timeScale = 1;
    }

   
    void Update()
    {
        if (isGameOver)     
            return;      

        totalTimeElapsed += Time.deltaTime;
        timeRemaining -= Time.deltaTime; 
        if (timeRemaining <= 0)
        {
            isGameOver = true;    
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
            GUI.Box(new Rect(Screen.width / 4, Screen.height / 6, Screen.width / 2, Screen.height / 2), "GAME OVER\nYOUR SCORE: " + (int)score);

            //restart the game on click
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 8), "RESTART"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            //exit the game
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + 2 * Screen.height / 9 + 10, Screen.width / 2 - 20, Screen.height / 8), "EXIT GAME"))
            {
                Application.Quit();
            }
        }
    }
}
