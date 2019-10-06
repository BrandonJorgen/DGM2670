using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public List<WaveCreator> waves;
    private Transform spawnPoint;
    private int i = 0;

    private void Start()
    {
        spawnPoint = GetComponent<Transform>();
    }

    public void UpdateWave()
    {
        if (i < waves.Count)
        {
            SpawnWave(waves[i].amountToSpawn);
            i++;
        }
        else
        {
            Debug.Log("End of Waves List");
        }
    }

    public void SpawnWave(int waveToSpawn)
    {
        Instantiate(waves[waveToSpawn].enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
