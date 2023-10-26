using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//method when the player decides to retry the game
    public void LoadGame()
    {
    //it uses the scene manager to load a new scene
    //loads the scene with an index 1 = SampleScene (we can use string as well)
        SceneManager.LoadScene(1);
    }
}
