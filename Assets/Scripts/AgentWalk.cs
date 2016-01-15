using UnityEngine;
using System.Collections;

public class AgentWalk : MonoBehaviour
{

    public Transform destination;

    private NavMeshAgent agent;

    void Update()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();

        agent.SetDestination(destination.position);
    }

}