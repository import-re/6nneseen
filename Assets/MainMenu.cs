using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioSource exitSound;
    //public GameObject OptionsScreen;


    void Start()
    {
        buttonSound = GetComponent<AudioSource>();
        exitSound = GetComponent<AudioSource>();
    }


    public void playGame()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Level1");
    }


    public void quitGame()
    {
        exitSound.Play();
        Application.Quit();
    }


    public void loadMainPage()
    {
        SceneManager.LoadScene("StartPage");
    }

    public void loadOptions()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Options");
        //OptionsScreen.SetActive(true);
    }
}
