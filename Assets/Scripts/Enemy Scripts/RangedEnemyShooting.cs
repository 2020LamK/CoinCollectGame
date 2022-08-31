using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 5f;
    public static bool canShoot = true;
    public float cooldown = 0.5f;

    void OnTriggerStay(Collider collider)
    {
        GameObject g = collider.gameObject;
        if (g.CompareTag("Player"))
        {
            // Face the target
            transform.LookAt(g.transform.position);

            // shoot target
            if (canShoot)
            {
                StartCoroutine(Shoot());
            }
        }
    }

    public IEnumerator Shoot() {
        {
            if (RockProperties.stunned) {
                canShoot = false;
                yield return new WaitForSeconds(5f);
                canShoot = true;
                RockProperties.stunned = false;
            }
            else {
                // create bullet
                GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

                // get bullet rigidbody
                Rigidbody rb = bullet.GetComponent<Rigidbody>();

                // fire bullet
                rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);

                // wait before firing again
                canShoot = false;
                yield return new WaitForSeconds(cooldown);
                canShoot = true;
            }
        }
    }
}
