using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;
    public GameObject PlayerPrefub;
    public Transform playerSpawn;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }


    void Update()
    {
        target = GameObject.Find("Player").transform;

        var yAxis = new Dictionary<string, float>()
        {
            { "Level1", 0.67f },
            { "Level2", 0.67f },
            { "Level3", 0.67f },
            {"BossScene", 0.1f}
        };

        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if(target is null)
        {
            if (sceneName == "Level1")
            {
                Instantiate(PlayerPrefub, playerSpawn.position, playerSpawn.rotation);
            }
        }

        float _fixedHeight;
        if (yAxis.TryGetValue(sceneName, out _fixedHeight))
        {
            Vector3 newPos = new Vector3(target.position.x,_fixedHeight,-10f);
            transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed*Time.deltaTime);
        }
        else
        {
            Debug.Log($"scene name is invalid {sceneName}");
        }
    }
}
