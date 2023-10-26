using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerLives : MonoBehaviour
{

//the amount of lives
    public int lives = 3;

//UI representing player's lives    
    public Image[] livesUI;

//reference to an explosion prefab
    public GameObject explosionPrefab;

//reference to UI panel
    public GameObject gameOverPanel;

//UI element displaying thr current number of lives    
    public TMP_Text livesText;

//reference to pointmanager = manages the score/point
    public PointManager pointManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//this method gets called when a collision happens(so it checks if the player collides with an object)
    private void OnCollisionEnter2D(Collision2D collision)
    {
    //checks if the player collides with a gameobejct that has tag called enemmy
        if(collision.collider.gameObject.tag == "Enemy")
        {
        //destroys enemy gameobject
            Destroy(collision.collider.gameObject);
        //creates an instance of the explosion effect at the player's position
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        //decreases the player's life    
            lives -=1;

        //for loop updates the UI elements representing the player's lives
            for(int i=0; i<livesUI.Length;i++)
            {
                if(i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }

        //if the player runs out of lives
            if(lives<=0)
            {
            //destroys the player
                Destroy(gameObject);
            //sets the time to zero
                Time.timeScale = 0;
            //actvates the gameoverpanel
                gameOverPanel.SetActive(true);
            //calls on pointmanager, updates highscore
                pointManager.highScoreUpdate();
                
            }
        }
    }

}
