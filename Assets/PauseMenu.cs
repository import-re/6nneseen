using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPaused;
    public AudioSource pauseMusic;
    public GameObject PauseM;
    public GameObject PlayerStats;
    public helpMenu helpMenu;
    public GameObject Settings;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseM.activeInHierarchy)
            {
                unPause();
            }
            else
            {
                Pause();
            }
        }
    }

    
    public void Start()
    {
        PlayerStats.SetActive(true);
        PauseM.SetActive(false);
        Settings.SetActive(false);
    }


    public void Quit()
    {
        Application.Quit();
    }


    public void OpenSetting()
    {
        Settings.SetActive(true);
    }


    public void CloseSetting()
    {
        Settings.SetActive(false);
    }


    public void Pause()
    {
        helpMenu.Level1Musc.Pause();
        PauseM.SetActive(true);
        gameIsPaused = true;
        pauseMusic.Play();
        
    }

    public void unPause()
    {
        pauseMusic.Pause();
        helpMenu.Level1Musc.Play();
        PauseM.SetActive(false);
        gameIsPaused = false;
    }
}
