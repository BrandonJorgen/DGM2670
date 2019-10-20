using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateObj : MonoBehaviour
{
    public GameObject prefabToInstatiate;
    
    public void Spawn()
    {
        Instantiate(prefabToInstatiate, transform.position, Quaternion.identity);
    }
}