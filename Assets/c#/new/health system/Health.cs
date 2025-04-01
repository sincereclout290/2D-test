using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth; 
    public int currentHealth;

    DoorDestroywhenallaredead doorDestroyer;

    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;
        doorDestroyer = FindObjectOfType<DoorDestroywhenallaredead>();
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        doorDestroyer.EnemyDied(gameObject);
        Destroy(gameObject);
    }

}
