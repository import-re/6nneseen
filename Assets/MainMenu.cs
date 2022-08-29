using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public AudioSource buttonSound;

    void Start()
    {
        buttonSound = GetComponent<AudioSource>();
    }


    public void playGame()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Level1");
    }


    public void quitGame()
    {
        Application.Quit();
    }
}
