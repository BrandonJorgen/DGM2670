using UnityEngine;
using UnityEngine.Events;

public class FixedUpdateEvent : MonoBehaviour
{
    public UnityEvent fixedUpdateEvent;
    
    private void FixedUpdate()
    {
        fixedUpdateEvent?.Invoke();
    }
}