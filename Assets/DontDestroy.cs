using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if(sceneName != "Level1" | sceneName != "Level2" | sceneName != "Level3"){
            DontDestroyOnLoad(gameObject);
        }
    }
}
