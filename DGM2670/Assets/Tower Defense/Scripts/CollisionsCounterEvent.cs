using UnityEngine;
using UnityEngine.Events;

public class CollisionsCounterEvent : MonoBehaviour
{
    public int intValue = 0, intTarget = 1;
    public UnityEvent underTargetEvent, reachedTargetEvent;

    private void OnTriggerEnter(Collider other)
    {
        intValue++;

        if (intValue < intTarget)
        {
            underTargetEvent?.Invoke();
        }
        else
        {
            reachedTargetEvent?.Invoke();
        }
    }
}