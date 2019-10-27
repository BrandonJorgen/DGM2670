using System.Collections.Generic;
using UnityEngine;

public class LimitedInstatiateObj : MonoBehaviour
{
    public GameObject prefabToInstatiate;
    public FloatData instObjCount;
    
    public void Spawn()
    {
        if (instObjCount.value <= 0)
        {
            Instantiate(prefabToInstatiate, transform.position, transform.rotation);
            instObjCount.value++;
        }
    }
}
