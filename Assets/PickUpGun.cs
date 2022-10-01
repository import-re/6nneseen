using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour
{
    public GameObject player;
    public GameObject Pyss;
    public GameObject Pudel;

    private bool weaponHit = false;
    //private bool isAttached;
    public bool pickUphasBeenCalled;
    public Player playerScript;



//check if Player has a child with tag "Meele", if not pick up.
//If
    void Start()
    {
        player = GameObject.Find("Player");
        //GameObject Pudel = GameObject.FindGameObjectWithTag("Meele");
        //GameObject Pyss = GameObject.FindGameObjectWithTag("Weapon");
    }
    void Update()
    {
        if (weaponHit && Input.GetKeyDown(KeyCode.E) & !playerScript.weaponIsAttached)
        {
            PickUp();
        }


        if (Input.GetKeyDown("q") && playerScript.weaponIsAttached)
        {
            DropWeapon();
        }
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
        transform.localPosition = new Vector3(0.7f, 0.15f);
        pickUphasBeenCalled = true;
        Debug.Log("eskere");
    }


    void DropWeapon()
    {
        transform.parent = null;
        pickUphasBeenCalled = false;
        Destroy(gameObject);    

        //set parent to null and set the new weapon as a child
    }
}