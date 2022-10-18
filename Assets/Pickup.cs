using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;
    public GameObject Pyss;
    public GameObject Pudel;

    private bool weaponHit = false;
    //private bool isAttached;
    public bool pickUphasBeenCalled;
    public Player playerScript;
    public CharacterController2D playerMovingScript;


    void Start()
    {
    }
    void Update()
    {
        player = GameObject.Find("Player");
        Pudel = GameObject.FindGameObjectWithTag("Meele");
        Pyss = GameObject.FindGameObjectWithTag("Weapon");
        //Debug.Log("weaponIsAttached" + playerScript.weaponIsAttached);
       // Debug.Log("pickUphasBeenCalled" + pickUphasBeenCalled);
        if (weaponHit && Input.GetKeyDown(KeyCode.E) && !playerScript.weaponIsAttached && playerMovingScript.m_FacingRight)
        {
            PickUp();
        }


        /*if (Input.GetKeyDown("q") && playerScript.weaponIsAttached)
        {
            DropWeapon();
        }*/
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            weaponHit = true;
        }

    }


    void PickUp()
    {
        transform.SetParent(player.transform);
        if(gameObject == Pudel)
        {
            transform.localPosition = new Vector3(0.9f, 0.6f);
        }
        else
        {
            transform.localPosition = new Vector3(0.7f, 0.15f);
        }
        pickUphasBeenCalled = true;
        //Debug.Log("eskere");
    }


    void DropWeapon()
    {
        transform.parent = null;
        pickUphasBeenCalled = false;

        if(gameObject == Pudel)
        {
            Pudel.SetActive(false);
            //Destroy(Pudel);
        }

        else
        {
            Pyss.SetActive(false);
            //Destroy(Pyss);    
        }
        
        //set parent to null and set the new weapon as a child
    }
}