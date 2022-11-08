using UnityEngine;

public class helpMenu : MonoBehaviour
{
    public GameObject helpImage;
    public GameObject AllMenu;
    public GameObject helpText;
    public bool helpMenuIsActive;
    public AudioSource pauseMusic;
    public GameObject PlayerStats;
    public GameObject Paused;
    public AudioSource Level1Musc;


    void Start()
    {
        helpImage.SetActive(false);
        helpText.SetActive(true);
        pauseMusic.Play();
        PlayerStats.SetActive(true);
    }


    void Update()
    {
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
        pauseMusic.Pause();
        Level1Musc.Play();
    }

    public void openHelpMenu()
    {
        helpImage.SetActive(true);
        helpMenuIsActive = true;
        pauseMusic.Play();
        Level1Musc.Pause();
    }
}
