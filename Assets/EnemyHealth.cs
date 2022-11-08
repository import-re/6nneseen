using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentEhealth = 100000;
    string enemyType;
    private int eHealth;


    void Awake()
    {
        gameObject.SetActive(true);
        var EnemyHealthes = new Dictionary<string, int>()
        {
            {"EnemySeen", 9},
            {"EnemyKass", 12},
            {"OranzKoletis", 6},
            {"RohelineKoletis", 9},
            {"Boss", 35}
        };
        string enemyType = gameObject.tag;
        if (EnemyHealthes.TryGetValue(enemyType, out eHealth))
        {
            currentEhealth = eHealth;
            Debug.Log(enemyType + " 's health is " + eHealth);
        }
        else
        {
            Debug.Log("This enemy type doesn't exist" + enemyType);
        }
    }

    void Start()
    {
        gameObject.SetActive(true);
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            TakeDamage(3);
            Destroy(coll.gameObject);
        }


        if (coll.gameObject.tag == "Grenade")
        {
            TakeDamage(2);
            Destroy(coll.gameObject);
        }
    }


    public void TakeDamage (int damage)
    {
        currentEhealth -= damage;
        //Debug.Log(ehealth);
        if (currentEhealth <= 0)
        {
            Die();
        }
    }


    void Die()
    
    {
        Debug.Log("Die");
        Destroy(gameObject);
    }

}
