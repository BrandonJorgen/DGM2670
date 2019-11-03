using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TimedEvent : MonoBehaviour
{
    public UnityEvent timedEvent;

    public void ExecTimedEvent(float seconds)
    {
        StartCoroutine(ExecEvent(seconds));
    }

    IEnumerator ExecEvent(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        timedEvent?.Invoke();
    }
}