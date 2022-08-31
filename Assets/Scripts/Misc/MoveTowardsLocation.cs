using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsLocation : MonoBehaviour
{
    public float tx = 0;  // Location to move towards
    public float ty = 0;
    public float tz = 0;
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // Determine direction from difference between target and currect locations
        Vector3 delta = new Vector3(tx, ty, tz) - transform.position;

        // Normalize it to have a magnitude of 1 
        delta.Normalize();
        // Multiply by speed and frame rate
        delta *= Time.deltaTime * speed;

        // Translate by this amount 
        transform.Translate(delta, Space.World);
    }
}
