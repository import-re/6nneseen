using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float Speed;
    public Vector3 LaunchOffset;
    public bool Thrown;
    [SerializeField] GameObject exploParticles;
    public float timer = 2;
    float countdown;
    public Transform bombTransform;


    void Start()
    {
        countdown = timer;
        if (Thrown)
        {
            var direction = transform.right + Vector3.up;
            GetComponent<Rigidbody2D>().AddForce(direction*Speed, ForceMode2D.Impulse);
        }
        transform.Translate(LaunchOffset);
        Destroy(gameObject,3);
    }


    public void Update()
    {
        if (!Thrown)
        {
            transform.position += transform.right * Speed * Time.deltaTime;
        }
    }



    void OnDestroy()
    {
        GameObject spawnedParcticle = Instantiate(exploParticles, bombTransform.position, bombTransform.rotation);
    }
}
