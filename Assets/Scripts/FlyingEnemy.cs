using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;


//the purpose of this script is: when the player gets too close to the enemies, they start to follow them
//and will return to their starting positions when the player exists the radius area


public class FlyingEnemyScript : MonoBehaviour
{

    public float speed;
    public float lineOfSite;
    public bool chase = false;
    public Transform startingPoint;
    public Transform bulletSpawn;
    public float shootingRange;
    public float fireRate = 1f;
    private float nextFireTime;
    public GameObject bullet;
    public GameObject bulletParent;

    //reference to the player position
    private GameObject player;
    private EnemySpawner spawner; 

    public Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
    //we are finding the player, but we need to assign a tag through the unity inspector first to find them
        player=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    //if the player is null, the enemy acts as if they don't exist
        if(player==null)
    //stop executing this part of code at this line
        return;

        if(chase==true)
    //executing the chase method we did below
        Chase();

    //if the player gets out of the radius, the enemy stops following them(thinking they don't exist again) and they return to their starting point
    //    else
   

    //flip the enemy and change the rotation on y-axis
    //    Flip();
    }


//chasing the player
    private void Chase()
    {
    //to make things a bit easier we will do a float that will calculate us a distance from the player(where is the player)
        float distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
    
    //if the player is in the enemy's line of sight but it won't move if it's in the shooting range
        if(distanceFromPlayer<=lineOfSite && distanceFromPlayer>shootingRange)
        {
        //we need to change the "location" = to move towards them we need:(position of the enemy, position on which enemy needs to move(that's the position of the player), speed MULTIPLIED BY time(per frame in unity)(which is the formula for distance;)))) )
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position,speed * Time.deltaTime);
        }

    //but if the distance from the player is less or equal than a shooting range
        else if (distanceFromPlayer<=shootingRange && nextFireTime <Time.time)
        {
        //instantiate = the creation of an object(instance of a given class) in OOP
            //instantiating an object called bullet from bulletParent + we want no rotation
            Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
        //after one bullet is fired it will take one second for the nemy to fire the next bullet    
            nextFireTime = Time.time + fireRate;
        }

        //to set the chase to true we need to put some kind of the colider that would start the chase
    }

  

   // private void Flip()
   // {
    //if the position on the x-axis is bigger then then the position of the player on the x-axis
     //   if(transform.position.x>player.transform.position.x)
    //change the rotation - 0,0,0 is the default
    //(so the enemy is on the right side and by default it's facing to the left)   
    //    transform.rotation = Quaternion.Euler(0, 0, 0);
    //else the enemy is on the left, so we need to rotate it by 180 degrees on y-axis   
    //    else
    //        transform.rotation = Quaternion.Euler(0, 100, 0);
   // }

//to see how big the line of site will be, and how big and where it's going to be
//it will be the on the enemy (ofc)
    private void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }

    public void Initialize(EnemySpawner spawnerReference)
    {
       spawner = spawnerReference;
  }
}
