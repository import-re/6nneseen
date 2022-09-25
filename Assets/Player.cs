using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    //public int damage;
    public int currentHealth;
    public HealthBar healthbar;
    public Text text;
    public int coinCounter;


    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "EnemySeen")
        {
            TakeDamage(2);
        }
        if (coll.gameObject.tag == "Collectible")
        {
            AddCoins();
            AddCoinCounter();
        }
        if (coll.gameObject.tag == "Spikes")
        {
            TakeDamage(1);
        }
        if (coll.gameObject.tag == "EnemyKass")
        {
            TakeDamage(4);
        }
        if (coll.gameObject.tag == "Boss")
        {
            TakeDamage(5);
        }
        if(coll.gameObject.tag == "HealthBooster" & currentHealth < maxHealth)
        {
            BoostHealth();
        }
        if (coll.gameObject.tag == "RohelineKuul")
        {
            TakeDamage(2);
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


    public void AddCoins()
    {
        coinCounter++;
    }


    public void AddCoinCounter()
    {
        text.text = coinCounter.ToString();
    }

    public void BoostHealth()
    {
        currentHealth++;
        healthbar.SetHealth(currentHealth);
    }

}
