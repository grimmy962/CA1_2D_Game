using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{

//represents current score in the game
    public int score;
//reference to UI element that displays the current score
    public TMP_Text scoreText;

//displays finalscore  
    public TMP_Text finalScoreText;
//displays highscore
    public TMP_Text highScoreText;

    void Start()
    {
    //sets the text of scoretext ui to display the score: and inputs the curernt score
        scoreText.text = "Score: "+score;
    }


    // Updates score
    public void UpdateScore(int points)
    {
    //increases the score by the point value
        score += points;
    //updates the scoretext ui to show the updated score
        scoreText.text = "Score: "+score;
    }

//method responsible for updating the high score    
    public void highScoreUpdate()
    {
    //chceck if there's already a highscore
        if(PlayerPrefs.HasKey("SavedHighScore"))
        {
            //checks if the current one is bigger than the saved one
            if(score > PlayerPrefs.GetInt("SavedHighScore"))
            {
             //set a new highscore   
             PlayerPrefs.SetInt("SavedHighScore", score);
            }
        }

        else{
            //if there's no high score then make one
            PlayerPrefs.SetInt("SavedHighScore", score);
        }
    //sets the text of finalscoretext to display the final score
        finalScoreText.text = score.ToString();
    // -||- the high score
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
