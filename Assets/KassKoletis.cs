using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KassKoletis : MonoBehaviour
{
    public int ehealth = 120;

    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 whereToMove;
    public float moveSpeed = 0f;


    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update(){
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        moveCharacter(movement);
    }


    void moveCharacter(Vector2 direction){
        whereToMove = (Vector2)transform.position + (direction * moveSpeed * Time.deltaTime);
        Debug.Log(whereToMove);
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
            Destroy(coll.gameObject);
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

