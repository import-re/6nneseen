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
        if (weaponHit && Input.GetKeyDown(KeyCode.E))
        {
            checkIsBeingHeld();
            if (isBeingHeld == false)
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
        if (gameObject.transform.parent != null && gameObject.transform.parent.tag == "Weapon")
        {
            Debug.Log("The weapon isbeing held");
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
        transform.parent = null;
        Destroy(gameObject);
        //set parent to null and set the new weapon as a child
    }

}