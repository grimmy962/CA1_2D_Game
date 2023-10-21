using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;

    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    //so the target of the bullet is a gameobject that has a tag called Player
        target = GameObject.FindGameObjectWithTag("Player");
    //to find the direction where it needs to move it needs to calculate the position of the target(where it's moving) and multiplies it by speed
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
    //after this^ the bullet will fire in the direction of the player based on the x and y
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);

    }

    
    void Update()
    {
        
    }
}
