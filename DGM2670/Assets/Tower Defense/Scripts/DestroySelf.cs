using System.Collections;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public bool useTimer;
    public float timer = 0f;

    private void Start()
    {
        if (useTimer)
        {
            StartCoroutine(SelfDestructTimer());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    IEnumerator SelfDestructTimer()
    {
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
    }
}
