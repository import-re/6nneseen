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
    public GameObject BombPrefab;
    public Transform LaunchOffset;
    public int GrenadeCount = 5;


    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire2") && GrenadeCount > 0)
        {
            ThrowGrenade();
            GrenadeCount--;
        }
        else if(GrenadeCount <= 0)
        {
            Debug.Log("You don't have any grenades left");
        }
    }


    void ThrowGrenade()
    {
        Instantiate(BombPrefab, LaunchOffset.position, transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "EnemySeen" | coll.gameObject.tag == "OranzKoletis")
        {
            TakeDamage(2);
        }
        if (coll.gameObject.tag == "Collectible")
        {
            AddCoins();
            AddCoinCounter();
        }
        if (coll.gameObject.tag == "Spikes" | coll.gameObject.tag == "VaikeKuul")
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
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "RohelineKuul")
        {
            Debug.Log(coll.gameObject.tag);
            TakeDamage(2);
            Destroy(coll.gameObject);
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
