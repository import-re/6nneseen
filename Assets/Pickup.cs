using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;

    private bool weaponHit = false;
    //private bool isAttached;
    public bool pickUphasBeenCalled;
    public Player playerScript;


    void Start()
    {
        player = GameObject.Find("Player");
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
        if(gameObject.tag == "Meele")
        {
            transform.localPosition = new Vector3(0.75f, 0.7f);
        }
        else
        {
            transform.localPosition = new Vector3(0.7f, 0.15f);
        }
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