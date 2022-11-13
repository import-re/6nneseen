using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;
    public GameObject Pyss;
    public GameObject Pudel;
    private bool weaponHit = false;
    public bool pickUphasBeenCalled;
    public Player playerScript;
    public CharacterController2D PlayersScript;

    void Start()
    {
        playerScript = player.GetComponent<Player>();
        PlayersScript = player.GetComponent<CharacterController2D>();
    }

    void Update()
    {
        player = GameObject.Find("Player");
        Pudel = GameObject.FindGameObjectWithTag("Meele");
        Pyss = GameObject.FindGameObjectWithTag("Weapon");
        if (weaponHit && Input.GetKeyDown(KeyCode.E) && !playerScript.weaponIsAttached && PlayersScript.m_FacingRight)
        {
            PickUp();
        }
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            weaponHit = true;
        }

    }


    void PickUp()
    {
        transform.SetParent(player.transform);
        if(gameObject == Pudel)
        {
            transform.localPosition = new Vector3(0.9f, 0.6f);
        }
        else
        {
            transform.localPosition = new Vector3(0.7f, 0.15f);
        }
        pickUphasBeenCalled = true;
    }


    void DropWeapon()
    {
        transform.parent = null;
        pickUphasBeenCalled = false;

        if(gameObject == Pudel)
        {
            Pudel.SetActive(false);
        }

        else
        {
            Pyss.SetActive(false);
        }
    }
}