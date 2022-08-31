using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    public static int damageValue = 10;
    
    public IEnumerator OnCollisionEnter(Collision collision)
    {
        GameObject c = collision.gameObject;
        if (c.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else 
        {
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
        }
    }
}
