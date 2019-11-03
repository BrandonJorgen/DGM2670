using System.Collections;
using UnityEngine;

public class PeriodicInstantiate : MonoBehaviour
{
    public GameObject instObj;
    public WaveCreator wave;
    private int currentInstantiatons;
    private bool currentlySpawning;

    public void SpawnInitialGroup()
    {
        StartCoroutine(InstTimer());
    }

    public void SpawnGroup()
    {
        if (currentlySpawning == false)
        {
            wave.numberOfEnemiesToSpawn++;
            currentInstantiatons = 0;
            StartCoroutine(InstTimer());
        }
    }

    IEnumerator InstTimer()
    {
        while (currentInstantiatons < wave.numberOfEnemiesToSpawn)
        {
            currentlySpawning = true;
            Debug.Log(currentlySpawning);
            Instantiate(instObj, transform.position, transform.rotation);
            currentInstantiatons++;
            yield return new WaitForSeconds(wave.delayBetweenSpawns);
        }

        currentlySpawning = false;
    }
}