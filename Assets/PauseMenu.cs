using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPaused;
    public AudioSource pauseMusic;
    public GameObject PauseM;
    public GameObject PlayerStats;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("eskre");
            if(PauseM.activeInHierarchy)
            {
                unPause();
            }
            else
            {
                Pause();
            }
        }

        /*if(gameIsPaused)
        {
            PlayerStats.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PlayerStats.SetActive(false);
            Time.timeScale = 1;
        }*/
    }

    
    public void Start()
    {
        PlayerStats.SetActive(true);
        PauseM.SetActive(false);
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
        PauseM.SetActive(true);
        gameIsPaused = true;
        pauseMusic.Play();
    }

    public void unPause()
    {
        pauseMusic.Stop();
        PauseM.SetActive(false);
        gameIsPaused = false;
        //level1Music.Play();
    }
}
