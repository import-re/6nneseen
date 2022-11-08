using UnityEngine;
using UnityEngine.SceneManagement; 

public class DontDestroy : MonoBehaviour
{
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if(sceneName == "Level1" | sceneName == "Level2" | sceneName == "Level3")
        {
            DontDestroyOnLoad(gameObject);
        }

        if (sceneName == "GameOver")
        {
            Destroy(gameObject);
        }
        
    }

    void Start()
    {
        gameObject.SetActive(true);
    }
}


