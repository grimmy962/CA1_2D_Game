using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{

    public int score;
    public TMP_Text scoreText;
  
    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;

    void Start()
    {
        scoreText.text = "Score: "+score;
    }

    // Update is called once per frame
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: "+score;
    }
    public void highScoreUpdate()
    {
    //chceck if httere's already a highscore
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

        finalScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
