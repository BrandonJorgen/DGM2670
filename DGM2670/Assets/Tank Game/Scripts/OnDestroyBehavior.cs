using UnityEngine;
using UnityEngine.Events;

public class OnDestroyBehavior : MonoBehaviour
{
    public UnityEvent onDestroyEvent;

    private void OnDestroy()
    {
        onDestroyEvent?.Invoke();
    }
}
