using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    public GameObject explosion;
    public string targetTag = "Target";

    void OnCollisionEnter(Collision c)
    {
        GameObject g = c.gameObject;
        if (g.CompareTag(targetTag))
        {
            Destroy(g);
        }
        
        // generate explosion
        GameObject e = Instantiate(explosion, transform.position, transform.rotation);
        
        // destroy after 1 sec
        Destroy(e, 1);

        Destroy(this.gameObject);
    }
}
