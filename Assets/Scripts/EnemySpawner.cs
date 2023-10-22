using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
     [SerializeField]
    private GameObject orangeEnemyPrefab; 

     [SerializeField]
     private GameObject pinkEnemyPrefab;

     [SerializeField]
     private GameObject greenEnemyPrefab; 
    
    [SerializeField]
     private float orangeSpawnRate = 3.5f;

     [SerializeField]
     private float pinkSpawnRate = 5f;

     [SerializeField]
     private float greenSpawnRate = 10f;

      [Header("Limit Settings")]
      [SerializeField] private int maxEnemies = 5; 
      private int currentEnemies = 0; 

    void Start()
    {
        StartCoroutine(spawnEnemy(orangeSpawnRate, orangeEnemyPrefab));
        StartCoroutine(spawnEnemy(pinkSpawnRate, pinkEnemyPrefab));
        StartCoroutine(spawnEnemy(greenSpawnRate, greenEnemyPrefab));
    }

   private IEnumerator spawnEnemy(float interval, GameObject enemy)
   {
        if(currentEnemies >= maxEnemies)

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));

        currentEnemies++;
   }
   public void EnemyDied(){
    currentEnemies--;
   }
}
