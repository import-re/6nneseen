using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    GameObject[] gameObjects;
    public GameObject player;
    public Transform playerSpawn;
    void Update()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Boss");
        if (gameObjects.Length == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }


    void Start()
    {
        Instantiate(player, playerSpawn.position, playerSpawn.rotation);
    }
}
