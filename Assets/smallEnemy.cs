using UnityEngine;

public class smallEnemy : MonoBehaviour
{
    public Transform player; 
    public float distance;
    public GameObject bigEnemy;
    public Transform spawnpoint;
    public Animator anim;
    public bool isDestroyed;
    public bool wasInvoked = false;
    public AudioSource Growing;


    void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    
    void Update()
    {
        distance = player.position.x - transform.position.x;
        anim.SetFloat("distance", Mathf.Abs(distance));
        if (Mathf.Abs(distance) < 10)
        {
            Growing.Play();
            if (wasInvoked == false)
            {
                wasInvoked = true;
                Invoke("transformEnemy", 2f);
            }
        }

    }


    void transformEnemy()
    {
        Destroy(gameObject);
        GameObject bigMartinEnemy = Instantiate(bigEnemy, spawnpoint.position, spawnpoint.rotation);
    }

}
