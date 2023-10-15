using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    //it's public because we want it to show up in unity, so that we can change up the value while we're play testing the game
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (about 60 times per second)
    void Update()
    {
        //translate = slide around, Vector2 = has x,y
        //it's movigng too fast, so we need to multiply it by deltTime = will move according to time (1 unit to the right/second)
        transform.Translate(Vector2.right *moveSpeed* Time.deltaTime);
    }
}
