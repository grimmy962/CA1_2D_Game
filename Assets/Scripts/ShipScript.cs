using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    //it's public because we want it to show up in unity, so that we can change up the value while we're play testing the game
    public float moveSpeed = 5;
    public float hInput;
    public float vInput;

    public Transform bulletSpawn;
    public float shootingRange;
    public float fireRate = 1f;
    private float nextFireTime;
    public GameObject bullet;
    public GameObject bulletParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (about 60 times per second)
    void Update()
    {
        //getaxisraw = take the button we push and if it's left = -1, right = 1, nothing = 0
        //"horizontal" - takes this value from the input manager
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

        //translate = slide around, Vector2 = has x,y
        //it's moving too fast, so we need to multiply it by deltTime = will move according to time (1 unit to the right/second)
        //after adding hInput - if left goes to left, etc.
        transform.Translate(Vector2.right *hInput *moveSpeed* Time.deltaTime);
        transform.Translate(Vector2.up *vInput * moveSpeed * Time.deltaTime);
    }
}
