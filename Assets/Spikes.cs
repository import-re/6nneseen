using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spikes : MonoBehaviour
{
    public Animator anim;
    public float distanceTillSpikes;
    public Transform player; 


    void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    void Update()
    {
        distanceTillSpikes = Mathf.Abs(player.position.x - transform.position.x);
        anim.SetFloat("distanceTillSpikes", distanceTillSpikes);
        //Debug.Log(distanceTillSpikes);
    }
}
