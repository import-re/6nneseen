using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int ehealth = 120;

    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 0f;


    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update(){
        Vector3 direction = player.position - transform.position;
        //Debug.Log(direction);
        direction.Normalize();
        movement = direction;
        moveCharacter(movement);
    }


    void FixepUpdate(){
        //moveCharacter(movement);
    }


    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
            Destroy(coll.gameObject); //destroying the bullets
        }
    }


    public void TakeDamage (int damage)
    {
        ehealth -= damage;

        if (ehealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }

}
