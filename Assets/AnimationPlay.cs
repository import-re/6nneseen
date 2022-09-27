using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
    //[SerializeField] private Animator anim;
    // Start is called before the first frame update
    public Animator anim;
    [SerializeField]private string bombBlink = "grenadeBlinks";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            //Debug.Log("eskere");
            anim.Play(bombBlink, 0, 0f);
            //anim.Play(bombBlink);
        }
    }
}
