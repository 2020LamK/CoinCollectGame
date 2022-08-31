using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAhead : MonoBehaviour
{
    public float rayDist = 20.0f;
   
    // Update is called once per frame
    void Update()
    {
        bool hitSomething = Physics.Raycast(transform.position,
                                            transform.forward,
                                            out RaycastHit hitdata,
                                            rayDist);

        if (hitSomething)
        {
        GameObject what = hitdata.collider.gameObject;
        float distance = hitdata.distance;
        Vector3 where = hitdata.point;
        Debug.Log("Facing " + what.name + " at " + where + " distance " + distance);
        }
        else
        {
            Debug.Log("Facing nothing");
        }
    }
}
