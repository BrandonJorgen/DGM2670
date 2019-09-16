using UnityEngine;
using UnityEngine.Events;

public class PauseBehavior : MonoBehaviour
{   
    public GameAction action;
    public UnityEvent zeroTimeScaleEvent, oneTimeScaleEvent;

    private void Start()
    {
        if (Time.timeScale >= 1)
        {
            action.action += ZeroTimeScale;
        }
        else
        {
            action.action += OneTimeScale;
        }
    }

    private void ZeroTimeScale()
    {
        zeroTimeScaleEvent?.Invoke();
        Time.timeScale = 0;
        Debug.Log(Time.timeScale);
    }

    private void OneTimeScale()
    {
        oneTimeScaleEvent?.Invoke();
        Time.timeScale = 1;
        Debug.Log(Time.timeScale);
    }
}
