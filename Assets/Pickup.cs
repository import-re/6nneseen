using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;
    public GameObject rifle;
    public GameObject melee;
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
        player = GameObject.FindGameObjectWithTag("Player");
        melee = GameObject.FindGameObjectWithTag("Meele");
        rifle = GameObject.FindGameObjectWithTag("Weapon");
        if (weaponHit && Input.GetKeyDown(KeyCode.E) && !playerScript.weaponIsAttached && PlayersScript.m_FacingRight)
        {
            PickUp();
        }
        if (Input.GetKeyDown(KeyCode.Q) && playerScript.weaponIsAttached)
        {
            DropWeapon();
        }
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            weaponHit = true;
        }

    }


    void OnCollisionExit2D(Collision2D other)
    {
        weaponHit = false;
    }


    void PickUp()
    {
        transform.SetParent(player.transform);
        transform.localPosition = new Vector3(0.9f, 0.6f);
        
        if(gameObject == melee)
        {
            transform.localPosition = new Vector3(0.9f, 0.6f);
        }
        else
        {
            transform.localPosition = new Vector3(0.7f, 0.15f);
        }
        pickUphasBeenCalled = true;
        playerScript.weaponIsAttached = true;
    }

    void DropWeapon()
    {
        pickUphasBeenCalled = false;
        transform.parent = null;
        playerScript.weaponIsAttached = false;
    }
}