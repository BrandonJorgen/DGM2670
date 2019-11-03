using System.Collections;
using UnityEngine;

public class PeriodicInstantiate : MonoBehaviour
{
    public GameObject instObj;
    public WaveCreator wave;
    private int currentInstantiatons;

    public void SpawnGroup()
    {
        StartCoroutine(InstTimer());
    }

    IEnumerator InstTimer()
    {
        while (currentInstantiatons < wave.numberOfEnemiesToSpawn)
        {
            Instantiate(instObj, transform.position, transform.rotation);
            currentInstantiatons++;
            yield return new WaitForSeconds(wave.delayBetweenSpawns);
        }
    }
}
