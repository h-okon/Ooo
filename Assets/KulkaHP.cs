using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KulkaHP : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
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
        /* only for debug purposes - when space is pressed */
       if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0) // respawn the player
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
