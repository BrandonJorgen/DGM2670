using UnityEngine;

public class FloatValueUpdate : MonoBehaviour
{
    public float value = 1f;

    public void MinusValue(FloatData data)
    {
        value -= data.value;
    }
}
