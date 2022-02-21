using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Vector3 playerPosition;
    public Vector3 weaponPosition;
    public GameObject player;
    //public GameObject relv;
    // Transform PlayerAttachment;
    //public Transform WeaponAttachment;

    private bool weaponHit = false;
    public bool isBeingHeld = false; 


    void Update()
    {
        checkIsBeingHeld();
        if (weaponHit && Input.GetKeyDown(KeyCode.E) && (isBeingHeld == false))
        {
            Debug.Log("E is pressed");
            PickUp();
        }
        else if (weaponHit && Input.GetKeyDown(KeyCode.E) && (isBeingHeld == true))
        {
            ChangeWeapon();
        }

    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Please press E to pick up the weapon.");
            weaponHit = true;
        }

    }

        void checkIsBeingHeld()
    {
        if (transform.parent == null)
        {
            //Debug.Log("The weapon is not being held");
            isBeingHeld = false;
        }
        else
        {
            //Debug.Log("The weapon is being held");
            isBeingHeld = true;
        }
    }


    void PickUp()
    {
        Debug.Log("yes");
        transform.SetParent(player.transform);
        //PlayerAttachment.transform.SetParent(WeaponAttachment.transform);
    }


    void ChangeWeapon()
    {
        if (Input.GetKey("e")) //if E is BEING HELD
        {
            //Debug.Log("E is held down");
            transform.parent = null;
            Destroy(gameObject);
            //set parent to null and set the new weapon as a child
            //PickUp();
        }
    }

}