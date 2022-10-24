using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Boss : MonoBehaviour
{
    public Slider bossHealthbar;
    public EnemyHealth health;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.currentEhealth < 17)
        {
            anim.SetTrigger("stageTwo");
        }

        if(health.currentEhealth <= 0)
        {
            anim.SetTrigger("death");
        }
        bossHealthbar.value = health.currentEhealth;
    }
}
