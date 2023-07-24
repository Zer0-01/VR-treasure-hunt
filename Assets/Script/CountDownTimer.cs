using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public float totalTime = 10f;  
    private float currentTime;   
    public TMP_Text myTimer;
    public TMP_Text game;
    bool  gameOver;

    private bool isRunning = true; // Flag to check if the timer is running

    void Start()
    {
        currentTime = totalTime;
        InvokeRepeating("UpdateTimer", 1f, 1f); // Invoke the UpdateTimer method every second
        game.text = " ";
        Time.timeScale = 1f;
        gameOver = false;
    }

    void UpdateTimer()
    {
        if (isRunning)
        {
             myTimer.text = "Time : " + currentTime;
            currentTime--;

            if (currentTime <= 0)
            {
                // Time's up, stop the game or perform any necessary actions
                isRunning = false;
                Debug.Log("Time's up!");
                myTimer.text = "Time : Time's up" ;
                game.text = "Game Over ";
                Time.timeScale = 0f;
                gameOver = true;
            }     
        }
     }              // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex ) ;
}
