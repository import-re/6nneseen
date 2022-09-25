using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeiderRohelineKoletis : MonoBehaviour
{
    public Transform firePoint;
    public Transform player; 
    public GameObject bulletPrefab;
    public float distance;
     GameObject[] bulletsATM;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.position.x - transform.position.x;
        bulletsATM = GameObject.FindGameObjectsWithTag("RohelineKuul");
        Debug.Log(distance);

        if (Mathf.Abs(distance) < 10 & bulletsATM.Length < 2)
        {
            InvokeRepeating("Shoot", 0f, 5f);
        }

    }
    

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}
