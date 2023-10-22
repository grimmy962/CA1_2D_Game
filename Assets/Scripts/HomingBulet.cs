using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBulet : MonoBehaviour
{
//speed for the bullet
    public float speed = 5;
//target to follow    
    Transform player;

    void Start()
    {
    //it will look for the player using transform and will read the tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
    //will make the bullet move towards the player using the transform, position of the player and the distance
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
    }
}
