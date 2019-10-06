using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class PathCheck : MonoBehaviour
{
    public VectorData destination;
    public UnityEvent pathFail, pathSuccess;
    private NavMeshAgent agent;
    private bool DestReached;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void NextWave()
    {
        UpdatePathData();
    }

    public void UpdatePathData()
    {
        NavMeshPath path = new NavMeshPath();
        agent.CalculatePath(destination.vectorData, path);

        if (path.status == NavMeshPathStatus.PathInvalid || path.status == NavMeshPathStatus.PathPartial)
        {
            pathFail?.Invoke();
        }
        else
        {
            pathSuccess?.Invoke();
        }
    }
}
