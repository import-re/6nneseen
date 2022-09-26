using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float Speed;
    public Vector3 LaunchOffset;
    public bool Thrown;
    //public Animation anim;
    public AudioSource explosion; 
    [SerializeField] GameObject exploParticles;
    public float timer = 2;
    float countdown;
    bool hasExploded;
    //public Animation explosionAnimation;

    void Start()
    {
        countdown = timer;
        //anim = gameObject.GetComponent<Animation>();
        if (Thrown)
        {
            var direction = transform.right + Vector3.up;
            GetComponent<Rigidbody2D>().AddForce(direction*Speed, ForceMode2D.Impulse);
        }
        transform.Translate(LaunchOffset);
        Destroy(gameObject,5);
    }


    public void Update()
    {
        countdown -= Time.deltaTime;
        if (!Thrown)
        {
            transform.position += transform.right * Speed * Time.deltaTime;
        }
    }



    void OnDestroy()
    {
        //anim.Play("explosionAnimation");
    }
}
