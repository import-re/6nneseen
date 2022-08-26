using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader2 : MonoBehaviour
{
    public string sceneToLoad;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
            //DontDestroyOnLoad(coll.gameObject);
        }

    }



}
