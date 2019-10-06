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
        //Find out when the next wave has started
        SpawnWave(waves[0].amountToSpawn);
        waves.RemoveAt(0);
    }

    public void SpawnWave(int waveToSpawn)
    {
        Instantiate(waves[waveToSpawn].enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
