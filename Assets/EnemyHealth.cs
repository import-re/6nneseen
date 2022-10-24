using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //private static int ehealth = 9;
    //private int currentEhealth = 0;
    //int currentEHealth;
    public int currentEhealth;
    string enemyType;

    void Awake()
    {
        //gameObject.SetActive(true);
        /*if (gameObject.tag == "EnemySeen")
        {
            ehealth = 9;
        }*/
    }

    void Update()
    {
        //Debug.Log($"{enemyType} is {currentEhealth}");
        Debug.Log(currentEhealth);
    }

    void Start()
    {
        //currentEhealth = ehealth;
        var EnemyHealthes = new Dictionary<string, int>()
        {
            {"EnemySeen", 9},
            {"EnemyKass", 12},
            {"OranzKoletis", 6},
            {"RohelineKoletis", 9},
            {"Boss", 35}
        };
        string enemyType = gameObject.tag;
        int eHealth;
        //int currentEhealth;
        //Debug.Log(enemyType);
        if (EnemyHealthes.TryGetValue(enemyType, out eHealth))
        {
            currentEhealth = eHealth;
        }

        //string enemyType = gameObject.tag;
        //private static int ehealth;
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
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }

}
