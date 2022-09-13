using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public Text Counter;
    public int coinCounter = 0;


    void OnCollision2DEnter(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log(coinCounter);
            coinCounter++;
            Counter.text = coinCounter.ToString();
        }
    }
}
