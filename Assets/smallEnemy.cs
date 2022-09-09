using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallEnemy : MonoBehaviour
{
    public Transform player; 
    public float distance;
    public GameObject bigEnemy;
    public Transform spawnpoint;
    public int number = 10;
    public Animator anim;
    public bool isDestroyed;



    void Update()
    {
        distance = player.position.x - transform.position.x;
        anim.SetFloat("distance", Mathf.Abs(distance));


        if (Mathf.Abs(distance) < 10)
        {
            if (isDestroyed == false)

            {
                Invoke("transformEnemy", 2f);
            }
            //transformEnemy();
        }

    }



    void transformEnemy()
    {
        Destroy(gameObject);
        isDestroyed = true;
        Instantiate(bigEnemy, spawnpoint.position, spawnpoint.rotation);
    }

}
