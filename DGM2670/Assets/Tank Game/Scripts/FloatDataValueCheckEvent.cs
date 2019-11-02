using UnityEngine;
using UnityEngine.Events;

public class FloatDataValueCheckEvent : MonoBehaviour
{
    public FloatData data;
    public UnityEvent dataIsZeroEvent, dataIsNotZeroEvent;

    public void LifeCountCheck()
    {
        if (data.value <= 0)
        {
            dataIsZeroEvent?.Invoke();
        }
        else
        {
            dataIsNotZeroEvent?.Invoke();
        }
    }
}