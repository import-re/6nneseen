using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bulletType;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public AudioSource shootingSound; 
    public bool isShooting = false;
    public Animator anim;
    public CharacterController2D playerMovingScript;


    void Start()
    {
        shootingSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        
        anim.SetBool("isShooting", isShooting);
        if (transform.parent != null)
        {
            if (Input.GetButtonDown("Fire1") && playerMovingScript.m_FacingRight)
            {
                ShootRandom();
            }
            
            else if (Input.GetButtonUp("Fire1"))
            {
                isShooting = false;
            }
            
        }
        Debug.Log(playerMovingScript.m_FacingRight);
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
        isShooting = true;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
