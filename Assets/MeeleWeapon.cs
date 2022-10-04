using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleWeapon : MonoBehaviour
{
    public bool isBeingHeld = false;
    private float timeBtwAttack;
    public float startTimeBtwAttack = 1;
    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public EnemyHealth enemy;
    public Animator anim;
    public bool isAttacking;
    void Update()
    {
        anim.SetBool("isAttacking", isAttacking);
        CheckIfIsBeingHeld();
        if(timeBtwAttack <= 0)
        {
            if (Input.GetButtonDown("Fire1") && isBeingHeld)
            {
                Attack();
                //Debug.Log("attacking");
                isAttacking = true;
            }
            timeBtwAttack = startTimeBtwAttack;
            if(Input.GetButtonUp("Fire1"))
            {
                isAttacking = false;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
        
    }

    void CheckIfIsBeingHeld()
    {
        if (transform.parent == null)
        {
            isBeingHeld = false;
        }

        else
        {
            isBeingHeld = true;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    void Attack()
    {
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
        for(int i =0; i < enemiesToDamage.Length; i++)
        {
            enemy.TakeDamage(1);
        }
    
    }
}
