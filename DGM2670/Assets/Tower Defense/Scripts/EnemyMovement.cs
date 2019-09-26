using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public FloatData movementSpeed;
    public Transform destination;
    
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.speed = movementSpeed.value;
        navAgent.destination = destination.position;
    }
}
