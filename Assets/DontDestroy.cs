using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DontDestroy : MonoBehaviour
{
    //public GameObject healthCollectiblesPause;
    //public GameObject Help;
    void Update()
    {
        //Debug.Log("Ma ei saa aru");
        /*if(Help.activeSelf)
        {
            Debug.Log("is active");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("no");
            gameObject.SetActive(true);
        }*/

        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if(sceneName == "Level1" | sceneName == "Level2")
        {
            DontDestroyOnLoad(gameObject);
        }
        
    }

    void Start()
    {
        gameObject.SetActive(true);
    }
}


