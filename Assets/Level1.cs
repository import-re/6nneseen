using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject pauseMenu;


    void Start()
    {
        pauseMenu.SetActive(false);
    }



    void Resume()
    {
        pauseMenu.SetActive(false);
    }


    void Quit()
    {
        Application.Quit();
    }


    void Setting()
    {
        Debug.Log("eskere");
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
    }
}
