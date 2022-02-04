using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerHealth = 10;
     GameObject heart1;
     GameObject heart2;
     GameObject heart3;


    void Start(){
        heart1 = GameObject.Find("heart1");
        heart2 = GameObject.Find("heart2");
        heart3 = GameObject.Find("heart3");
    }
    void Update()
    { 
        Debug.Log(playerHealth);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
            ChangeHealthBar();
        }
    }


    public void TakeDamage (int damage)
    {
        playerHealth -= damage;

        if (playerHealth <= 0)
        {
            Die();
        }
    }

    void ChangeHealthBar()
    {
        heart1.SetActive(false);
        heart2.SetActive(false);
        heart3.SetActive(false);
    }


    void Die()
    {
        Destroy(gameObject);
    }
}
