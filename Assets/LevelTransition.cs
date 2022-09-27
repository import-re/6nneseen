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
            //DontDestroyOnLoad(Canvas);
            DontDestroyOnLoad(coll.gameObject);
            StartCoroutine(LoadNextScene());
            //DontDestroyOnLoad(coll.gameObject);
        }

    }

    IEnumerator LoadNextScene()
    {
        crossfade.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneToLoad);

    }



}
