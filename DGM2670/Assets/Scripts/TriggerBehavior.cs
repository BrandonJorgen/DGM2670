using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent triggerEnter;
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEnter.Invoke();
    }
}
