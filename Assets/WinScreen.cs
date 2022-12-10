using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    private int loadNewScreen = 10;
    public GameObject PressAnyKey;
    public GameObject credits;
    private bool triggered;
    public Animator anim;
    float timeLeft = 10;
    float exitTimeLeft = 29;
    float maxTimeLeft = 30;
    public GameObject CloseBut;

    void Start()
    {
        credits.SetActive(false);
        PressAnyKey.SetActive(false);
        Invoke("LoadPressAnyKey", loadNewScreen);
        CloseBut.SetActive(false);
    }

    void Update()
    {
        anim.SetBool("triggered", triggered);
        timeLeft -= Time.deltaTime;
        exitTimeLeft -= Time.deltaTime;
        maxTimeLeft -= Time.deltaTime;
        if (timeLeft < 0 & Input.anyKey)
        {
            LoadCredits();
        }

        if (exitTimeLeft < 0 & Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (exitTimeLeft < 0)
        {
            CloseBut.SetActive(true);
        }
    }

    void LoadPressAnyKey()
    {
        PressAnyKey.SetActive(true);
    }

    void LoadCredits()
    {
        credits.SetActive(true);
        triggered = true;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
