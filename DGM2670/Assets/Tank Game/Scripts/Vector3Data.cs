using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 data;

    public void UpdateData(Transform objTransform)
    {
        data = objTransform.position;
    }
}
