using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    public int score;
    public int lives = 10;
    public GameObject loe;
    private bool gamegoing;

  

    //functions to manipulate the score and lives
    public void morescore()
    {
        score += 1;
    }
    public void loselife()
    {
        lives -= 1;
    }
    public void gainlife()
    {
        lives += 1;
    }
    public void losescore()
    {
        score -= 1;
    }


    //lets the scoreboard know the game ended
    private void endgame()
    {
        GameObject.Find("HighScores").GetComponent<HighScores>().GameOver();
    }
    private void Start()
    {
        gamegoing = true;
    }







    public void resetgamenunmbers()
    {
        score = 0;
        lives = 10;
        gamegoing = true;
    }

    //disables the game if you lose and tells the highscore board what to do
    void Update()
    {
        if (lives == 0 && gamegoing == true)
        {
            
            GameObject.Find("GameRunning").GetComponent<GameRunning>().disablegame();
            loe.SetActive(true);
            endgame();
            gamegoing = false;
            
        }

    }
}
