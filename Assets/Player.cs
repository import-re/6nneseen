using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    //public int damage;
    public int currentHealth;
    public HealthBar healthbar;
    public Text text;
    public Text textG;
    public int coinCounter;
    public GameObject BombPrefab;
    public Transform LaunchOffset;
    public int grenadeCount = 5;
    public int currentGrenadeCount;
    public bool hasChecked;


    void Start()
    {
        Debug.Log("neeeww");
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
                if(sceneName == "Level3")
                {
                    currentGrenadeCount = currentGrenadeCount + coinCounter;
                    textG.text = currentGrenadeCount.ToString();
                    hasChecked = true;
                }
            }
        if (Input.GetButtonDown("Fire2"))
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
        if (coll.gameObject.tag == "Spikes" | coll.gameObject.tag == "VaikeKuul")
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
            Debug.Log(coll.gameObject.tag);
            TakeDamage(2);
            Destroy(coll.gameObject);
        }
    }


    public void TakeDamage (int damage)
    {
        Debug.Log("gucci gang");
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
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
        //anim.Play();
        currentGrenadeCount = currentGrenadeCount - 1;
        textG.text = currentGrenadeCount.ToString();
    }

}
