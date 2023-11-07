using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public GameObject waveCounter;
    public EnemySpawner[] waves;
    private EnemySpawner currentWave;
    [SerializeField] private Transform[] spawnpoints;
    private int enemiesSpawned = 0;
    private int i = 0;
    private bool stopSpawning = false;
    public bool incrPossible = true;

    private void Awake()
    {
        currentWave = waves[i];
    }

    private void Update()
    {
        if (stopSpawning)
        {
            return;
        }
    }


    private void SpawnWave()
    {
        enemiesSpawned = 0;
        StartCoroutine(SpawnEnemiesWithDelay());
        
    }

    private IEnumerator SpawnEnemiesWithDelay()
    {
        for (int i = 0; i < currentWave.NumberToSpawn; i++)
        {
            int enemyIndex = Random.Range(0, currentWave.EnemiesInWave.Length);
            int spawnPointIndex = Random.Range(0, spawnpoints.Length);

            Instantiate(currentWave.EnemiesInWave[enemyIndex], spawnpoints[spawnPointIndex].position, spawnpoints[spawnPointIndex].rotation);

            enemiesSpawned++;

            if (enemiesSpawned < currentWave.NumberToSpawn)
            {
                yield return new WaitForSeconds(currentWave.TimeBtwnSpawn);
            }
            if (enemiesSpawned == currentWave.NumberToSpawn)
            {
                incrPossible = true;
            }
        }
    }

    public void IncrWave()
    {
        if(incrPossible)
        {
            incrPossible = false;
            SpawnWave();
            if (i + 1 < waves.Length)
            {
                i++;
                currentWave = waves[i];
                waveCounter.GetComponent<TMP_Text>().text = waves[i].name;
            }
            else
            {
                stopSpawning = true;
            }
            
        }
        
    }
}