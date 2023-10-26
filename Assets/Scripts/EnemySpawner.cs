using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
 [Header("Spawn Settings")]
 //referencing enemy prefabs in the script
 //they will be accesible through the inspector thanks to the serialized field
    [SerializeField] private GameObject enemyPrefab;

//swarmer interval
    [SerializeField] private float spawnRate = 4f; 
    [SerializeField] private Transform[] spawnPoints; 

    [Header("Limit Settings")]

//sets the max amount of enemies that can appear in the scene
    [SerializeField] private int maxEnemies = 5; 
    
//the current amount of enemies on the scene
    private int currentEnemies = 0; 

    // Start is called before the first frame update
    void Start()
    {
        //repeatedly invokes a method at a specified interval
        //spawn enemy = what is going to get invoke, spawn rate = delay before the first invocation (in sec.), spawn rate = time interval between subsequent invocations (also in sec.g)
        InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
    }

//method responsible for creating new enemies
    void SpawnEnemy(){
    //checks if the current amount of enemies is more than the max amount
        if(currentEnemies >= maxEnemies) return; 

    //selects a random spawn point from an array of spawnPoint
    //generates a random index within the range
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
    
    //creates a new instance of enemy
    //spawnPoint.position = position where the enemy will be created
    //quaternion = rotation
        GameObject spawnedEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);

    //retrieves a flying enemy script from the spawned enemy
        FlyingEnemyScript enemyController = spawnedEnemy.GetComponent<FlyingEnemyScript>();
        
    //  calls a method Initialize on the enemy controller  
        enemyController.Initialize(this);
    
    //tracking those enemies and spawning more of them
        currentEnemies++;
    }

    //enemy dead
    public void EnemyDied(){
    
    //bye bye enemy
        currentEnemies--;
    }
    
}
