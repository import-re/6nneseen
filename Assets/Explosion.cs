using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius = 100; 
    public AudioSource explosion; 
    public EnemyHealth other;
    //public GameObject PlayerScript;
    // Start is called before the first frame update
    void Start()
    {
        explosion.Play();
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        foreach(Collider2D nearbyObject in colliders)
        {
            Rigidbody2D rb = nearbyObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Debug.Log(colliders);
                rb.AddForce(transform.up * 25f, ForceMode2D.Impulse);
                other.TakeDamage(2);
            }

        }
        Destroy(gameObject, 0.5f);
        //hasExploded = true;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
