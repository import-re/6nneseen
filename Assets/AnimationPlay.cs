using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
    //[SerializeField] private Animator anim;
    // Start is called before the first frame update
    public Animator anim;
    public bool grenadeThrown;
    public Player player;
    public bool grenadeOut;
    void Start()
    {
        
    }

    // Update is called once per frame
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
