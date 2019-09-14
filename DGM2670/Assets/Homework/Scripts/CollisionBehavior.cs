using UnityEngine;
using UnityEngine.Events;

public class CollisionBehavior : MonoBehaviour
{
    public UnityEvent OnCollisionEvent;
    
    private void OnCollisionEnter(Collision other)
    {
        OnCollisionEvent.Invoke();
    }
}
