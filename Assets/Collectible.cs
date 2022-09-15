using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public Text text;
    public int coinCounter;


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coinCounter++;
            text.text = coinCounter.ToString();
            Destroy(gameObject);
        }
    }
}