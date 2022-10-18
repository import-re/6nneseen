using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DontDestroy : MonoBehaviour
{
    public GameObject healthCollectiblesPause;
    public GameObject Help;
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        DontDestroyOnLoad(Help);
        if(sceneName == "Level1" | sceneName == "Level2" | sceneName == "Level3"){
            DontDestroyOnLoad(healthCollectiblesPause);
        }
        else
        {
            Destroy(healthCollectiblesPause);
        }
    }
}
