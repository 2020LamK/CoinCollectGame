using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    public GameObject blood;
    public Transform bodyCenter;
    public int maxHealth = 100;
    public static int currentHealth;
    private bool collisionCheck;

    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(currentHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject e = collision.gameObject;

        if (e.CompareTag("Bullet"))
        {
            // get bullet's damage
            int damageValue = BulletProperties.damageValue;
            TakeDamage(damageValue);
        }
    }

    void TakeDamage(int damage)
    {
        // Instaniate blood particle to signal damage
        GameObject e = Instantiate(blood, bodyCenter.position, Quaternion.identity);

        // reduce health
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        // destroy character when out of health
        if (currentHealth <= 0)
        {
            GameObject g = Instantiate(blood, bodyCenter.position, Quaternion.identity);
        }
    }
}
