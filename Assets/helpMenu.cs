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
    public Level1 pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        //helpButton.SetActive(true);
        helpImage.SetActive(false);
        helpText.SetActive(true);
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
    }
    // Update is called once per frame
    public void closeHelpMenu()
    {
        //helpButton.SetActive(true);
        helpImage.SetActive(false);
        pauseMenu.gameIsPaused = false;
    }

    public void openHelpMenu()
    {
        //helpButton.SetActive(false);
        helpImage.SetActive(true);
        pauseMenu.gameIsPaused = true;
    }
}
