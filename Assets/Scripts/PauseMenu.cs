using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

//keeping track of whether the game is currently paused or not
    private bool isPaused;

//reference to the UI panel that can be activated or paused when the game is paused or resumed
    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //check if the pause button has been pressed
        if(Input.GetButtonDown("Pause"))
        {
        //if the game is already paused it calls on the resumegame method
            if(isPaused)
                ResumeGame();

        //if the game is not paused it calls the pausegame method to pause the game   
            else
                PauseGame();
              
        }
    }

//pause game method
    public void PauseGame()
    {
    //sets the time scale to zero
        Time.timeScale = 0;
    //activates the pausepanel and makes it visible
        pausePanel.SetActive(true);
    //sets ispaused variable to true -- makes the game paused
        isPaused = true;
    }

//method responsible for resuming the game after it's paused
    public void ResumeGame()
    {
    //sets time back to 1
        Time.timeScale = 1;
    //deactivates the pausepanel
        pausePanel.SetActive(false);
    //sests ispaused variable to false (the game is no longer paused)
        isPaused = false;
    }
}
