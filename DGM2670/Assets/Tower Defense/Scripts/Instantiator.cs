using System.Collections;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject prefab;
    public FloatData instRate;
    public bool useTimer;
    private Transform instPoint;

    private void Start()
    {
        instPoint = GetComponent<Transform>();
        if (useTimer)
        {
            StartCoroutine(InstTimer());
        }
    }

    IEnumerator InstTimer()
    {
        while (true)
        {
            if (transform.parent.parent.GetComponent<TargetSelect>().enemyInRange)
            {
                ObjInstantiate();
            }
        
            yield return new WaitForSeconds(instRate.value);
        }
    }

    public void ObjInstantiate()
    {
        Debug.Log("Starting Instantiation");
        Instantiate(prefab, instPoint.position, prefab.transform.rotation);
    }
}