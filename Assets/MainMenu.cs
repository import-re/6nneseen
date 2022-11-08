using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioSource exitSound;
    public GameObject optionsMenu;
    public AudioSource startMusic;
    public AudioSource opitonMusic;
    public GameObject startMenu;


    void Start()
    {
        buttonSound = GetComponent<AudioSource>();
        exitSound = GetComponent<AudioSource>();
        optionsMenu.SetActive(false);
        loadMainPage();

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
        opitonMusic.Stop();
        startMenu.SetActive(true);
        startMusic.Play();
    }

    public void loadOptions()
    {
        startMusic.Stop();
        buttonSound.Play();
        optionsMenu.SetActive(true);
        opitonMusic.Play();
    }

    public void closeOptions()
    {
        opitonMusic.Stop();
        buttonSound.Play();
        optionsMenu.SetActive(false);
        startMusic.Play();
    }
}
