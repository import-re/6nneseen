using UnityEngine;

public class WinScreen : MonoBehaviour
{
    private int loadNewScreen = 10;
    public GameObject PressAnyKey;
    public GameObject credits;
    private bool triggered;
    public Animator anim;
    float timeLeft = 10;
    float exitTimeLeft = 25;

    void Start()
    {
        credits.SetActive(false);
        PressAnyKey.SetActive(false);
        Invoke("LoadPressAnyKey", loadNewScreen);
    }

    void Update()
    {
        anim.SetBool("triggered", triggered);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 & Input.anyKey)
        {
            LoadCredits();
        }

        if (exitTimeLeft < 0 & Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
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
}
