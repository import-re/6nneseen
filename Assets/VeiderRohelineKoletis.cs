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
    [SerializeField] private float cooldown = 5;
    private float cooldownTimer;
    void Start()
    {
        
        player = GameObject.Find("Player").transform;
    }


    void Update()
    {
        distance = player.position.x - transform.position.x;
        //bulletsATM = GameObject.FindGameObjectsWithTag("RohelineKuul");
        //Debug.Log(distance);

        if (Mathf.Abs(distance) < 10)
        {
            if (gameObject.tag == "RohelineKoletis")
            {
                //ShootBurst();
            }
            else
            {
                Shoot();
            }
        }

    }
    

    void ShootBurst()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer > 0) return;
        cooldownTimer = cooldown;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void Shoot()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer > 0) return;
        cooldownTimer = cooldown;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}