using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool isBeingHeld = false;
    public int bulletType;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public AudioSource shootingSound; 


    void Start()
    {
        shootingSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        CheckIfIsBeingHeld();
        if (Input.GetButtonDown("Fire1") && isBeingHeld)
        {
            ShootRandom();
        }
        

    }


//Idea: i have three different bullet types, randomly select a bullet type and shoot
//eandom module?
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //Debug.Log("Shoot");
    }


    void ShootRandom()
    {
        bulletType = Random.Range(1,3);
        bulletType.ToString();
        if (bulletType == 1)
        {
            bulletPrefab = bulletPrefab1;
        }
        if (bulletType == 2)
        {
            bulletPrefab = bulletPrefab2;
        }
        if (bulletType == 3)
        {
            bulletPrefab = bulletPrefab3;
        }
        shootingSound.Play();
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


    void CheckIfIsBeingHeld()
    {
        if (transform.parent == null)
        {
            isBeingHeld = false;
        }

        else
        {
            isBeingHeld = true;
        }
    }
}
