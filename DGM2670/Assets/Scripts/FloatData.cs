using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float Value;

    public void UpdateValue(float amount)
    {
        Value += amount;
    }
}