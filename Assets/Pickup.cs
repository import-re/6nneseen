using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;

    private bool weaponHit = false;
    public bool isBeingHeld = false;


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
        //Instantiate(weapon, WeaponAttachmentOnPlayer.position, WeaponAttachmentOnPlayer.rotation, Transform parent, bool instantiateInWorldSpace = false);
        transform.SetParent(player.transform);
        transform.localPosition = new Vector3(0.7f, 0.3f);
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