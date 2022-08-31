using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour
{
    public float maxDist = 100.0f;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position,
                            target.transform.position - transform.position,
                            out RaycastHit data,
                            maxDist))
        {
            GameObject hit = data.collider.gameObject;
            if (hit == target)
            {
                Debug.Log("I see you!");
            }
            else
            {
                Debug.Log("You are hidden");
            }
        }
        else
        {
            Debug.Log("Nothing is visible");
        }

    }
}
