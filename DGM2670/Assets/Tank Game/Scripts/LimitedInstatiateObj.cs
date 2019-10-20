using System.Collections.Generic;
using UnityEngine;

public class LimitedInstatiateObj : MonoBehaviour
{
    public GameObject prefabToInstatiate;
    public List<GameObject> instObjs;
    
    public void Spawn()
    {
        if (instObjs.Count == 0)
        {
            var instObj = Instantiate(prefabToInstatiate, transform.position, Quaternion.identity);
            instObjs.Add(instObj);
        }
    }
}
