using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject pauseMenu;
    //public GameObject bombCounter;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenu.activeInHierarchy)
            {
                unPause();
            }
            else
            {
                Pause();
            }
        }
    }

    
    public void Start()
    {
        pauseMenu.SetActive(false);
        //bombCounter.SetActive(true);
    }



    /*public void Resume()
    {
        pauseMenu.SetActive(false);
    }*/


    public void Quit()
    {
        Application.Quit();
    }


    public void Setting()
    {
        Debug.Log("eskere");
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        //bombCounter.SetActive(false);
    }

    public void unPause()
    {
        pauseMenu.SetActive(false);
        //bombCounter.SetActive(true);
    }
}
