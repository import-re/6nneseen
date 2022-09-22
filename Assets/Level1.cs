using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseButt;

    void Update()
    {
        if (pauseMenu.active)
        {
            pauseButt.SetActive(false);
        }
    }
    public void Start()
    {
        pauseMenu.SetActive(false);
        pauseButt.SetActive(true);
    }



    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButt.SetActive(true);
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
    }
}
