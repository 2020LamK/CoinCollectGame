using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAwayTag : MonoBehaviour
{
    public float speed = 1f;

    // run away while player within trigger
    void OnTriggerStay(Collider collider)
    {
        GameObject g = collider.gameObject;
        if (g.CompareTag("Player"))
        {
            // Determine direction from difference between target and current locations
            Vector3 delta = g.transform.position - transform.position;

            // Normalize it to have a magnitude of 1 
            delta.Normalize();
            // Multiply by speed and frame rate
            delta *= Time.deltaTime * speed;

            // Translate by this amount 
            transform.Translate(-delta, Space.World);
        }
    }
}
