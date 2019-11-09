using UnityEngine;
using UnityEngine.Events;

public class SpawnSelection : MonoBehaviour
{
    public UnityEvent locationOne, locationTwo;
    public float result;

    public void GetNumber()
    {
        result = Random.Range(1, 3);
    }

    public void SelectSpawn()
    {
        GetNumber();

        if (result == 1f)
        {
            locationOne?.Invoke();
        }
        else
        {
            locationTwo?.Invoke();
        }
    }
}