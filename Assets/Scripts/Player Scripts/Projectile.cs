using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;
    public float force = 10.0f;
    public bool playerShoot = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            // create a projectile at pos and rot
            GameObject p = Instantiate(projectile, 
            firePoint.position, firePoint.rotation);
            
            // get rigidbody component and apply force along local z axis
            Rigidbody prb = p.GetComponent<Rigidbody>();

            // prb.AddRelativeForce(new Vector3(0, 0, force), ForceMode.Impulse);
            prb.AddForce(firePoint.forward * force, ForceMode.Impulse);
            
            // destroy after 2 seconds
            Destroy(p, 5);
        }
    }
}
