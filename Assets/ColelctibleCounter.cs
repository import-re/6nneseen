using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColelctibleCounter : MonoBehaviour
{
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (sceneName == "BossScene")
        {
            gameObject.SetActive(false);
        }
    }
}
