using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
 [Header("Spawn Settings")]
    [SerializeField] private GameObject enemyPrefab; 
    [SerializeField] private float spawnRate = 4f; 
    [SerializeField] private Transform[] spawnPoints; 

    [Header("Limit Settings")]
    [SerializeField] private int maxEnemies = 5; 
    private int currentEnemies = 0; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
    }
    void SpawnEnemy(){
        if(currentEnemies >= maxEnemies) return; 

        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject spawnedEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);

        FlyingEnemyScript enemyController = spawnedEnemy.GetComponent<FlyingEnemyScript>();
        enemyController.Initialize(this);

        currentEnemies++;
    }
    public void EnemyDied(){
        currentEnemies--;
    }
    
}
