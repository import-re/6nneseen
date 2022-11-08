using UnityEngine;
using UnityEngine.UI;


public class Boss : MonoBehaviour
{
    public Slider bossHealthbar;
    public EnemyHealth health;
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


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
