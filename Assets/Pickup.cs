using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;

    private bool weaponHit = false;
    //private bool isBeingHeld = false;


    void Update()
    {
        if (weaponHit && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }


        if (Input.GetKeyDown("q") && transform.parent != null)
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
        //isBeingHeld = true;
    }


    void DropWeapon()
    {
        transform.parent = null;
        //isBeingHeld = false;
        Destroy(gameObject);
        //set parent to null and set the new weapon as a child
    }
}