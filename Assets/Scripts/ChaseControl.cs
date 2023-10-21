using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseControl : MonoBehaviour
{

//there's going to be more than one enemy to make it fun
    public FlyingEnemyScript[] enemyArray;


//when the player enters the trigger, it will compare the tag to find out if it is the player
//if it is then every enemy in the array will start chase
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            foreach(FlyingEnemyScript enemy in enemyArray)
            {
                enemy.chase = true;
            }
            
        }
    }

//when the player exists the trigger, it will read the tag again and then every enemy will stop the chase
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
        foreach(FlyingEnemyScript enemy in enemyArray)
        {
            enemy.chase = false;
        }
        
        }
}
}
