using System.Collections;
using UnityEngine;

public class TimedInstantiateObj : MonoBehaviour
{
    public GameObject instObj, instPoint;
    public float seconds = 1f;

    public void StartTimer()
    {
        StartCoroutine(TimedInstantiate());
    }

    IEnumerator TimedInstantiate()
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(instObj, instPoint.transform.position, instPoint.transform.rotation);
    }
}