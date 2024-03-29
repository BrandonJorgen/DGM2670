﻿using UnityEngine;
using UnityEngine.AI;

public class AgentDestination : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
    }
}
