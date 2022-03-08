using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Vector3 playerPosition;
    public Vector3 weaponPosition;
    public GameObject player;
    public GameObject weapon;
    // Transform PlayerAttachment;
    public Transform WeaponAttachmentOnPlayer;

    private bool weaponHit = false;
    public bool isBeingHeld = false; 

    public Transform parent;


    void Update()
    {
        checkIsBeingHeld();
        DropWeapon();
        if (weaponHit && Input.GetKeyDown(KeyCode.E) && (isBeingHeld == false))
        {
            //Debug.Log("E is pressed");
            PickUp();
        }

    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //Debug.Log("Please press E to pick up the weapon.");
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
        Instantiate(weapon, WeaponAttachmentOnPlayer.position, WeaponAttachmentOnPlayer.rotation, Transform parent, bool instantiateInWorldSpace = false);
        //transform.SetParent(player.transform);
        //Destroy(gameObject);
        //PlayerAttachment.transform.SetParent(WeaponAttachment.transform);
    }


    void DropWeapon()
    {
        if (Input.GetKey("q")) //if E is BEING HELD
        {
            //Debug.Log("E is held down");
            transform.parent = null;
            Destroy(gameObject);
            //set parent to null and set the new weapon as a child
            //PickUp();
        }
    }

}