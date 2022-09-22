using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader2 : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject Canvas;


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            DontDestroyOnLoad(Canvas);
            DontDestroyOnLoad(coll.gameObject);
            SceneManager.LoadScene(sceneToLoad);
            //DontDestroyOnLoad(coll.gameObject);
        }

    }



}
