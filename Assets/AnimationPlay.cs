using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
        public Animator anim;
    public bool grenadeThrown;
    public Player player;
    public bool grenadeOut;


    void Update()
    {
        anim.SetBool("grenadeTrown", grenadeThrown);
        anim.SetBool("grenadeOut", grenadeOut);
        if (Input.GetKeyDown("g") & player.grenadeCount > 0)
        {
            grenadeThrown = true;

        }
        if (Input.GetKeyDown("g") & player.grenadeCount <= 0)
        {
            grenadeOut = true;

        }
        if (Input.GetKeyUp("g"))
        {
            grenadeThrown = false;
            grenadeOut = false;
        }
    }
}
