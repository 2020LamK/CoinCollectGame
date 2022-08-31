using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;
    public int max = 25; // recompute path after this many frames
    int count = 0; // frames since last recompute

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // recompute target location every 25 frames
        count++;
        if (!agent.pathPending && count > max)
        {
            count = 0;
            agent.destination = target.transform.position;

        }
    }
}
