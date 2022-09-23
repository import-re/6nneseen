using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spikes : MonoBehaviour
{
    public Animator anim;
    public float distance;
    public Transform player; 


    void Update()
    {
        distance = player.position.x - transform.position.x;
        anim.SetFloat("distance", Mathf.Abs(distance));
        //Debug.Log(distance);
    }
}
