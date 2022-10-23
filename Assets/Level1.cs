using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool gameIsPaused;

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

        if(gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    
    public void Start()
    {
        pauseMenu.SetActive(false);
    }


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
        gameIsPaused = true;
    }

    public void unPause()
    {
        pauseMenu.SetActive(false);
        gameIsPaused = false;
    }
}
