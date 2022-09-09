//The current problem is that checkIsBeingheld bool is the same for both of the weapons. While shotgun doesn't have a


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;

    private bool weaponHit = false;
    private bool itisBeingHeld = false;
    private bool Children = false;


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
        //Instantiate(weapon, WeaponAttachmentOnPlayer.position, WeaponAttachmentOnPlayer.rotation, Transform parent, bool instantiateInWorldSpace = false);
        transform.SetParent(player.transform);
        transform.localPosition = new Vector3(0.7f, 0.15f);
        itisBeingHeld = true;
    }


    void DropWeapon()
    {
        transform.parent = null;
        itisBeingHeld = false;
        Destroy(gameObject);
        //set parent to null and set the new weapon as a child
    }
}


        //checkIsItBeingHeld();
        /*if (weaponHit && Input.GetKeyDown(KeyCode.E))
        {
            checkChildren();
            //Debug.Log("Trying to pick up a weapon");
            //checkIsBeingHeld();
            if (Children == true)
                {
                    Debug.Log("Can't pick up two weapons at once,");
                }


            if (transform.childCount == 0)
                {
                    PickUp();
                }


            else
            {
                //Debug.LogError("I'm confused");
            }
        }



    void checkChildren()
    {
        int children = transform.childCount;
        //if (children > 0)
        if (children > 3)
        {
            Children = true;
            Debug.Log(children);
        }
    }

    


    /*void checkIsItBeingHeld()
    {
        if (transform.parent != null)
        {
            //Debug.Log("This object's parent is " + transform.parent.name);
            Debug.Log("The object is being held");
            itisBeingHeld = true;
        }

        
    }*/