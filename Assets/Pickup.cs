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
        if (weaponHit && Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("Trying to pick up a weapon");
            checkIsBeingHeld();
            if (isBeingHeld == true)
                {
                    Debug.Log("Can't pick up two weapons at once,");
                }
            else
            {
                PickUp();
            }
        }


        if (Input.GetKey("q") && isBeingHeld)
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

    void checkIsBeingHeld()
    {
        if (transform.parent != null)
        {
            //Debug.Log("This object's parent is " + transform.parent.name);
            Debug.Log("The object is being held");
            isBeingHeld = true;
        }
    }


    void PickUp()
    {
        //Instantiate(weapon, WeaponAttachmentOnPlayer.position, WeaponAttachmentOnPlayer.rotation, Transform parent, bool instantiateInWorldSpace = false);
        transform.SetParent(player.transform);
        transform.localPosition = new Vector3(0.7f, 0.3f);
        isBeingHeld = true;
    }


    void DropWeapon()
    {
        transform.parent = null;
        isBeingHeld = false;
        Destroy(gameObject);
        //set parent to null and set the new weapon as a child
    }

}