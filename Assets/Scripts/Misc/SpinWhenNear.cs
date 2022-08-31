using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWhenNear : MonoBehaviour
{
    public float spinSpeed = 10.0f;

    // print msg player is nearby
    void OnTriggerEnter(Collider collider)
    {
        GameObject g = collider.gameObject;
        if (g.CompareTag("Player"))
        {
            Debug.Log("Player nearby!");
        }
    }

    // print msg player left collider
    void OnTriggerExit(Collider collider)
    {
        GameObject g = collider.gameObject;
        if (g.CompareTag("Player"))
        {
            Debug.Log("Player no longer nearby!");
        }
    }

    // rotate while player within trigger
    void OnTriggerStay(Collider collider)
    {
        GameObject g = collider.gameObject;
        if (g.CompareTag("Player"))
        {
            transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        }
    }
}
