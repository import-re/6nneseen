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


    void Update()
    {
        distance = player.position.x - transform.position.x;


        if (distance < 0)
        {
            distance = distance * -1;
            if (distance < number)
            {
                transformEnemy();

            }
        }

    }



    void transformEnemy()
    {
        Destroy(gameObject);
        Instantiate(bigEnemy, spawnpoint.position, spawnpoint.rotation);


    }

}
