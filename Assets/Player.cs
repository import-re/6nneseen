using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthbar;
    public Text text;
    public Text textG;
    public int coinCounter;
    public GameObject BombPrefab;
    public Transform LaunchOffset;
    public int grenadeCount = 5;
    public int currentGrenadeCount;
    private bool hasChecked;
    public bool weaponIsAttached;
    public PauseMenu pause;
    public helpMenu help;


    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        currentGrenadeCount = grenadeCount;
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if(!hasChecked)
            {
                if(sceneName == "BossScene")
                {
                    currentGrenadeCount = currentGrenadeCount + coinCounter;
                    textG.text = currentGrenadeCount.ToString();
                    hasChecked = true;
                }
            }
        if (Input.GetButtonDown("Fire2") & !pause.gameIsPaused & !help.helpMenuIsActive)
        {
            if(currentGrenadeCount > 0)
            {
                ThrowGrenade();
                GrenadeCounting();
            }
            else if(currentGrenadeCount <= 0)
            {
                Debug.Log("You don't have any grenades left");
            }
        }


        /*foreach (Transform iChild in transform)
        {
            string tag = iChild.gameObject.tag;
            if (tag == "Weapon" | tag == "Meele")
            {
                weaponIsAttached = true;
            }
            else
            {
                weaponIsAttached = false;
            }
        }*/
    }


    void ThrowGrenade()
    {
        Instantiate(BombPrefab, LaunchOffset.position, transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "EnemySeen" | coll.gameObject.tag == "OranzKoletis")
        {
            TakeDamage(2);
        }

        if (coll.gameObject.tag == "Collectible")
        {
            AddCoins();
            AddCoinCounter();
        }
        if (coll.gameObject.tag == "Spikes")
        {
            TakeDamage(1);
        }
        if (coll.gameObject.tag == "EnemyKass")
        {
            TakeDamage(4);
        }
        if (coll.gameObject.tag == "Boss")
        {
            TakeDamage(5);
        }
        if(coll.gameObject.tag == "HealthBooster" & currentHealth < maxHealth)
        {
            BoostHealth();
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "RohelineKuul")
        {
            TakeDamage(2);
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "Vaikekuul")
        {
            TakeDamage(1);
            Destroy(coll.gameObject);
        }
    }


    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject, 1);
            Die();
        }
    }



    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }


    public void AddCoins()
    {
        coinCounter++;
    }


    public void AddCoinCounter()
    {
        text.text = coinCounter.ToString();
    }

    public void BoostHealth()
    {
        currentHealth++;
        healthbar.SetHealth(currentHealth);
    }

    public void GrenadeCounting()
    {
        currentGrenadeCount = currentGrenadeCount - 1;
        textG.text = currentGrenadeCount.ToString();
    }

}
