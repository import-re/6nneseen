using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpMenu : MonoBehaviour
{
    //public Button helpButton;
    public GameObject helpImage;
    public GameObject AllMenu;
    public GameObject helpText;
    public bool helpMenuIsActive;
    public AudioSource pauseMusic;
    public GameObject PlayerStats;
    public GameObject Paused;


    void Start()
    {
        helpImage.SetActive(false);
        helpText.SetActive(true);
        pauseMusic.Play();
        PlayerStats.SetActive(true);
    }


    void Update()
    {
        //Debug.Log("the help menu is opened: " + helpMenuIsActive);
        if(Input.GetKeyUp("h"))
        {
            if (helpImage.activeInHierarchy)
            {
                closeHelpMenu();
                AllMenu.SetActive(true);
            }
            else
            {
                helpText.SetActive(false);
                openHelpMenu();
                AllMenu.SetActive(false);
            }
        }


        if (helpText.activeInHierarchy | Paused.activeInHierarchy | helpImage.activeInHierarchy)
        {
            //helpMenuIsActive = true;
            PlayerStats.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
            PlayerStats.SetActive(true);
        }
    }

    public void closeHelpMenu()
    {
        helpImage.SetActive(false);
        helpMenuIsActive = false;
        pauseMusic.Stop();
    }

    public void openHelpMenu()
    {
        helpImage.SetActive(true);
        helpMenuIsActive = true;
        pauseMusic.Play();
        //pauseMusic.Play();
        //level1.level1Music.Stop();
    }
}
