using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject healthBooster;
    public Transform HealSpawnPoint;

    void Start()
    {
        HealSpawnPoint = GameObject.Find("HealSpawnPoint").transform;
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (sceneName == "Level3")
        {
            InvokeRepeating("Spawn", 10f, 10f);
        }
    }

    void Spawn()
    {
        Instantiate(healthBooster, HealSpawnPoint.position, HealSpawnPoint.rotation);
    }
}
