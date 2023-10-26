using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
//the speed of the projectile    
    public float moveSpeed;
//reference to the explosion prefab
    public GameObject explosionPrefab;
//reference to the pointmanager class    
    private PointManager pointManager;

    // Start is called before the first frame update
    void Start()
    {
    //finds a game object called pointmanager in the scene, gets the pointmanager component attached to it and assigns it to the pointmanager variable making a reference to the point management system
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
    //moves the pprojectile upwards at the movespeed that is multiplied by the time (distance formula)
        transform.Translate(Vector2.up*moveSpeed*Time.deltaTime);
    }

//method tha gets caled when the projectile collides with a collider
    public void OnTriggerEnter2D(Collider2D collision)
    {
    //checks if the object that it collided with has the tag enemy
        if(collision.gameObject.tag == "Enemy")
        {
        //creates an instance of explosion effect at the projectile's position
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        //destroys the enemy game object
            Destroy(collision.gameObject);
        //calls an updatescore method from the pointmanager to increasee the players score by 10
            pointManager.UpdateScore(10);
        //destroys the projectile
            Destroy(gameObject);
        }
    //checks if it collides with an object with a tag boundary
        if(collision.gameObject.tag == "Boundary")
        {
        //if it does it destroys the projectile
            Destroy(gameObject);
        }
    }
}
