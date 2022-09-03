using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
    public bool isShooting = false;
    public Animator anim;
    //public Animation shooting;
    //public UnityEvent OnShootingEvent;


    void Start()
    {
        shootingSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        anim.SetBool("isShooting", isShooting);
        CheckIfIsBeingHeld();
        if (Input.GetButtonDown("Fire1") && isBeingHeld)
        {
            ShootRandom();
        }
        
        else if (Input.GetButtonUp("Fire1"))
        {
            isShooting = false;
        }
        
    }


    void ShootRandom()
    {
        bulletType = Random.Range(1,4);
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
        //anim.CrossFade(shooting);
        isShooting = true;
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
