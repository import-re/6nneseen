using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 3;
    public int damage;
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
        if (coll.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
        if (coll.gameObject.tag == "Collectible")
        {
            AddCoins();
            AddCoinCounter();
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
}
