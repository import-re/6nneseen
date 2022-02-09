using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E is pressed");
                PickUp();
            }
            else
            {
                Debug.Log("Please press E to pick up the weapon.");
            }
        }

    }


    void PickUp()
    {
        Debug.Log("yes");
    }
}
