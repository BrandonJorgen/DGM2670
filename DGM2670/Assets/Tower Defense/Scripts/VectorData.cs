using UnityEngine;

[CreateAssetMenu]
public class VectorData : ScriptableObject
{
    public Vector3 vectorData;

    public void GrabData(Transform transform)
    {
        vectorData = transform.position;
    }
}
