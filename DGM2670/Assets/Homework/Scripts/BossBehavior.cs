using UnityEngine;
using UnityEngine.Events;

public class BossBehavior : MonoBehaviour
{
    public GameAction action;
    public UnityEvent bossStartEvent;
    
    void Start()
    {
        action.action += BossStart;
    }

    private void BossStart()
    {
        bossStartEvent?.Invoke();
    }
}