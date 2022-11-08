using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius = 100; 
    public AudioSource explosion; 
    public EnemyHealth enemy;

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
                enemy.TakeDamage(2);
            }

        }
    }


}
