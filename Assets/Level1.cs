using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool gameIsPaused;
    public AudioSource pauseMusic;
    public AudioSource level1Music;

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
        level1Music.Play();
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
        //level1Music.Stop();
        pauseMenu.SetActive(true);
        gameIsPaused = true;
        pauseMusic.Play();
    }

    public void unPause()
    {
        //pauseMusic.Stop();
        pauseMenu.SetActive(false);
        gameIsPaused = false;
        level1Music.Play();
    }
}
