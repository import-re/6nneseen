using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AudioSource buttonSound;

     public void quitGame()
    {
        buttonSound.Play();
        Application.Quit();
    }


    public void StartOver()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Level1");
    } 

    public void LoadStartMenu()
    {
        buttonSound.Play();
        SceneManager.LoadScene("StartPage"); 
    }
}
