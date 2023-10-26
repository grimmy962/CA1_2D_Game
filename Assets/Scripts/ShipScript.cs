using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
//it's public because we want it to show up in unity, so that we can change up the value while we're play testing the game
//speed of the ship
    public float moveSpeed = 5;
//horizontal input
    public float hInput;
//vertical input
    public float vInput;
//stores things like left, right, up or down

//reference to the point in the game where the bullets are going to be spawned
    public Transform bulletSpawn;
//determines the maximum distance at which the ship can shoot
    public float shootingRange;
//firing rate of the ship
    public float fireRate = 1f;
//keeps a track of when the ship can fire again
    private float nextFireTime;
//reference to the bullet prefab gameobject
    public GameObject bullet;
//organizes instantiated bullets
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
