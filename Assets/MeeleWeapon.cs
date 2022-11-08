using UnityEngine;

public class MeeleWeapon : MonoBehaviour
{
    public bool isBeingHeld = false;
    private float timeBtwAttack;
    public float startTimeBtwAttack = 1.0f;
    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public EnemyHealth enemyHealthScript;
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
        if (enemiesToDamage != null)
        {
            foreach (Collider2D enemy in enemiesToDamage)
            {
                enemyHealthScript.TakeDamage(1);
            }
        }
    }
}
