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
    public float shootingRange;
    public GameObject bullet;
    public GameObject bulletParent;

    //reference to the player position
    private GameObject player;

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
        else
            ReturnStartPoint();

    //flip the enemy and change the rotation on y-axis
        Flip();
    }


//chasing the player
    private void Chase()
    {
    //we need to change the "location" = to move towards them we need:(position of the enemy, position on which enemy needs to move(that's the position of the player), speed MULTIPLIED BY time(per frame in unity)(which is the formula for distance;)))) )
        if(Vector2.Distance(transform.position, player.transform.position)<=lineOfSite)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position,speed * Time.deltaTime);
            //change speed, shoot, animation
        }
        else
        {
            //reset variable
        }

        //to set the chase to true we need to put some kind of the coolider that would start the chase
    }

    private void ReturnStartPoint()
    {
    //to change the position = to move towards the starting point(change the position to the starting point(wherever the position is), speed multiplied by time per frame(distance formula))
        transform.position=Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);
    }

    private void Flip()
    {
    //if the position on the x-axis is bigger then then the position of the player on the x-axis
        if(transform.position.x>player.transform.position.x)
    //change the rotation - 0,0,0 is the default
    //(so the enemy is on the right side and by default it's facing to the left)   
        transform.rotation = Quaternion.Euler(0, 0, 0);
    //else the enemy is on the left, so we need to rotate it by 180 degrees on y-axis   
        else
            transform.rotation = Quaternion.Euler(0, 100, 0);
    }

//to see how big the line of site will be, and how big and where it's going to be
//it will be the on the enemy (ofc)
    private void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }
}
