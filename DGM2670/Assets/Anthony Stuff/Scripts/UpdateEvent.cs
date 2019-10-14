using UnityEngine;
using UnityEngine.Events;

public class UpdateEvent : MonoBehaviour
{
    public UnityEvent onUpdateEvent;
    
    void Update()
    {
        onUpdateEvent.Invoke();
    }
}
