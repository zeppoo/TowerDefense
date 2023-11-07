using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySpawner", menuName = "ScriptableObjects/EnemySpawners", order = 1)]
public class EnemySpawner : ScriptableObject
{
    [field: SerializeField]
    public GameObject[] EnemiesInWave { get; private set; }

    [field: SerializeField]
    public float TimeBtwnSpawn { get; private set; }

    [field: SerializeField]
    public float NumberToSpawn { get; private set; }
}
