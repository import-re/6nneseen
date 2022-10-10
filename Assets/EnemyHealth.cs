using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int ehealth;
    public LillaSeen lillaSeeneScript;

    void Start()
    {
        if (gameObject.tag == "EnemySeen")
        {
            ehealth = lillaSeeneScript.lillaSeenHealth;
        }
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
        ehealth -= damage;
        Debug.Log(ehealth);
        if (ehealth <= 0)
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
