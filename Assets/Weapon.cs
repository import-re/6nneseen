using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bulletType;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public AudioSource shootingSound; 
    public bool isShooting = false;
    public Animator anim;
    public CharacterController2D playerMovingScript;
    public PauseMenu pause;
    public helpMenu help;


    void Start()
    {
        shootingSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        
        anim.SetBool("isShooting", isShooting);
        if (transform.parent != null)
        {
            if (Input.GetButtonDown("Fire1") && playerMovingScript.m_FacingRight & !pause.gameIsPaused & !help.helpMenuIsActive)
            {
                ShootRandom();
            }
            
            else if (Input.GetButtonUp("Fire1"))
            {
                isShooting = false;
            }
            
        }
    }


    void ShootRandom()
    {
        bulletType = Random.Range(1,4);
        bulletType.ToString();
        if (bulletType == 1)
        {
            bulletPrefab = bulletPrefab1;
        }
        if (bulletType == 2)
        {
            bulletPrefab = bulletPrefab2;
        }
        if (bulletType == 3)
        {
            bulletPrefab = bulletPrefab3;
        }
        shootingSound.Play();
        isShooting = true;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
