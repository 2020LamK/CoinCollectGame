using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockProperties : MonoBehaviour
{
    public static bool stunned = false;
    public GameObject stunP;

    public IEnumerator OnCollisionEnter(Collision collision)
    {
        GameObject c = collision.gameObject;

        if (c.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            // Instaniate stun particle to signal damage
            GameObject e = Instantiate(stunP, c.transform.position, Quaternion.identity);
            stunned = true;
        }

        else 
        {
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
        }
    }
}
