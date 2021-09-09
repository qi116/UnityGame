using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int currScore = 0;
    public static int playerLives = 5;
    public static bool gameOn = true;

    void Start()
    {

        DontDestroyOnLoad(gameObject);



    }
    public static void addScore(int point)
    {
        currScore += point;
    }
    public static void finalizeScore()
    {
        score += currScore;
        currScore = 0;
    }
    public static void loseLife()
    {
        playerLives--;
        if(playerLives <= 0)
        {
            gameOn = false;
        }
        
    }
    // Update is called once per frame
    
}
