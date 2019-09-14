using UnityEngine;
using UnityEngine.Events;

public class DeathScript : MonoBehaviour
{
    public GameAction action;
    public FloatData healthData;
    public UnityEvent deathEvent;

    private void Start()
    {
        action.action += DeathCheck;
    }

    private void DeathCheck()
    {
        if (healthData.value <= 0)
        {
            deathEvent?.Invoke();
        }
    }
}