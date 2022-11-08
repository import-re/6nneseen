using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public string sceneToLoad;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Scene currentScene = SceneManager.GetActiveScene ();
            string sceneName = currentScene.name;
            
            if (sceneName != "BossScene")
            {
                DontDestroyOnLoad(coll.gameObject);
                StartCoroutine(LoadNextScene());
            }
            else
            {
                StartCoroutine(LoadNextScene());
            }
        }

    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneToLoad);
    }
}
