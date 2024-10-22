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
    int timesPlayed;
    public GameObject cartoon;
    public AudioSource cartoonMusc;
    private float TimeTillTransition = 49;
    float timeTillStart = 85;
    public GameObject TrippyAnimation;
    bool hasChecked;
    bool hasCheckedAnim;



    void Start()
    {
        timesPlayed = PlayerPrefs.GetInt("TimesPlayed", 0);
        timesPlayed++;
        PlayerPrefs.SetInt("TimesPlayed", timesPlayed);
        buttonSound = GetComponent<AudioSource>();
        exitSound = GetComponent<AudioSource>();
        optionsMenu.SetActive(false);
        TrippyAnimation.SetActive(false);
        if (timesPlayed >= 2)
        {
            loadMainPage();
        }
        else
        {
            LoadCartoon();
        }

    }

    void Update()
    {
        TimeTillTransition -= Time.deltaTime;
        Debug.Log(TimeTillTransition);
        timeTillStart -= Time.deltaTime;
        if (TimeTillTransition < 0 & !hasCheckedAnim)
        {
            TrippyAnimation.SetActive(true);
            hasCheckedAnim = true;
        }
        if (timeTillStart < 0 & !hasChecked)
        {
            loadMainPage();
            hasChecked = true;

        }
    }


    void LoadCartoon()
    {
        cartoon.SetActive(true);
        cartoonMusc.Play();
        startMusic.Pause();
        opitonMusic.Pause();
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
        cartoonMusc.Stop();
        cartoon.SetActive(false);
        TrippyAnimation.SetActive(false);
        opitonMusic.Stop();
        startMenu.SetActive(true);
        startMusic.Play();
        cartoonMusc.Pause();
    }

    public void loadOptions()
    {
        startMusic.Stop();
        cartoonMusc.Pause();
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
