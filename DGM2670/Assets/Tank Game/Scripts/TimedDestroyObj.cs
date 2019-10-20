using System.Collections;
using UnityEngine;

public class TimedDestroyObj : MonoBehaviour
{
    public FloatData Seconds;
    
    private void Start()
    {
        StartCoroutine(DestroyObjTimer());
    }

    IEnumerator DestroyObjTimer()
    {
        yield return new WaitForSeconds(Seconds.value);
        Destroy(gameObject);
    }
}
