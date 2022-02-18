using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Vector3 playerPosition;
    public Vector3 weaponPosition;
    public GameObject player;
    public GameObject relv;
    // Transform PlayerAttachment;
    //public Transform WeaponAttachment;

    private bool weaponHit = false;


    void Update()
    {
        if (weaponHit && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E is pressed");
            PickUp();
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


    void PickUp()
    {
        Debug.Log("yes");
        relv.transform.SetParent(player.transform);
        //PlayerAttachment.transform.SetParent(WeaponAttachment.transform);
    }
}
