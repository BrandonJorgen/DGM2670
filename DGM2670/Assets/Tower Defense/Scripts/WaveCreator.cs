using UnityEngine;

[CreateAssetMenu]
public class WaveCreator : ScriptableObject
{
    public int numberOfEnemiesToSpawn;
    [Tooltip("Not used if only 1 (one) thing is spawned")]
    public float delayBetweenSpawns;
}