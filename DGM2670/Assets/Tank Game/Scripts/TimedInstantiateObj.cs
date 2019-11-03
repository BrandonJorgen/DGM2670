using System.Collections;
using UnityEngine;

public class TimedInstantiateObj : MonoBehaviour
{
    public GameObject instObj;
    public float seconds = 1f;

    public void Start()
    {
        StartCoroutine(TimedInstantiate());
    }

    IEnumerator TimedInstantiate()
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(instObj, transform.position, transform.rotation);
    }
}