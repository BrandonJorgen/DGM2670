using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    //Every new wave: Spawn Set
    //Use Wave Creator

    public List<WaveCreator> waves;
    public FloatData currentWave;
    private Transform spawnPoint;

    private void Start()
    {
        spawnPoint = GetComponent<Transform>();
    }

    public void UpdateWave()
    {
        currentWave.value++;
        
        for (int i = 0; i < currentWave.value; i++)
        {
            SpawnWave(i - 1);
        }
    }

    public void SpawnWave(int waveToSpawn)
    {
        Instantiate(waves[waveToSpawn].enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
