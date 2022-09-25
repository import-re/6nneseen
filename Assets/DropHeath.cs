using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHeath : MonoBehaviour
{
    public GameObject healthBooster;
    public Transform HealSpawnPoint;

    void Start()
    {
        InvokeRepeating("Spawn", 5f, 5f);
    }

    void Spawn()
    {
        Instantiate(healthBooster, HealSpawnPoint.position, HealSpawnPoint.rotation);
    }
}
