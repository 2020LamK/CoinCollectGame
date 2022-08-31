using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentPatrol : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0; // index of current waypoint
    public float closeEnough = 0.5f;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false; // prevents agent from stopping at every waypoint
        agent.destination = waypoints[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // change to next waypoint when close enough to current one
        if (!agent.pathPending && agent.remainingDistance < closeEnough)
        {
            // change to next waypoint in array as destination, cycle to start if necessary
            current = (current + 1) % waypoints.Length;
            agent.destination = waypoints[current].transform.position;
        }
    }
}
