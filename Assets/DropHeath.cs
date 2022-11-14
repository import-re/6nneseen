using UnityEngine;
using UnityEngine.SceneManagement;

public class DropHeath : MonoBehaviour
{
    public GameObject healthBooster;
    public Transform HealSpawnPoint;
    private bool hasChecked; 

    void Update()
    {
        HealSpawnPoint = GameObject.Find("HealSpawnPoint").transform;
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (sceneName == "BossScene" & !hasChecked)
        {

            InvokeRepeating("Spawn", 10f, 10f);
            hasChecked = true;
        }
    }

    void Spawn()
    {
        Instantiate(healthBooster, HealSpawnPoint.position, HealSpawnPoint.rotation);
        Debug.Log("Instantiating health booster");
    }
}
