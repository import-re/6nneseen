using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public string sceneToLoad;
    //public GameObject Canvas;
    public Animator crossfade;

    void Start()
    {
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("Menu");
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Scene currentScene = SceneManager.GetActiveScene ();
            string sceneName = currentScene.name;
            if (sceneName != "Level3")
            {
            //DontDestroyOnLoad(Canvas);
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
        crossfade.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneToLoad);

    }



}
