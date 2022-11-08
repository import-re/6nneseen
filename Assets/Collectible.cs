using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}