using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public static int count = 0;

    void OnCollisionEnter(Collision collision)
    {
        // get gameobject we collided with
        GameObject g = collision.gameObject;

        // target
        if (g.CompareTag("Target")) 
        {
            // destroy object
            GameObject.Destroy(g);

            // add to count
            count++;
        }

        // void
        if (g.CompareTag("Void"))
        {
            PlayerProperties.currentHealth=0;
        }
    }
}
