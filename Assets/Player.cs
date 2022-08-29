using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 3;
     GameObject heart1;
     GameObject heart2;
     GameObject heart3;
     public int damage;
     public int currentHealth;
     public HealthBar healthbar;


    void Start(){
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }


    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }



    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }
}
