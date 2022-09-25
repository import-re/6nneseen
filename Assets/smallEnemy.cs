using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallEnemy : MonoBehaviour
{
    public Transform player; 
    public float distance;
    public GameObject bigEnemy;
    public Transform spawnpoint;
    public Animator anim;
    public bool isDestroyed;
    public bool wasInvoked = false;


    void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    
    void Update()
    {
        //Debug.Log(distance);
        distance = player.position.x - transform.position.x;
        anim.SetFloat("distance", Mathf.Abs(distance));


        if (Mathf.Abs(distance) < 10)
        {
            if (wasInvoked == false)
            {
                wasInvoked = true;
                Invoke("transformEnemy", 2f);
            }
        }

    }



    void transformEnemy()
    {
        Destroy(gameObject);
        Instantiate(bigEnemy, spawnpoint.position, spawnpoint.rotation);
    }

}
