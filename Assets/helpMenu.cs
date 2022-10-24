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
    public bool helpMenuIsActive;
    // Start is called before the first frame update
    void Start()
    {
        //helpButton.SetActive(true);
        helpImage.SetActive(false);
        helpText.SetActive(true);
    }


    void Update()
    {
        Debug.Log("the help menu is opened: " + helpMenuIsActive);
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


        if (helpText.activeInHierarchy)
        {
            helpMenuIsActive = true;
            Time.timeScale = 0f;
        }

        if(helpMenuIsActive)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    // Update is called once per frame
    public void closeHelpMenu()
    {
        //helpButton.SetActive(true);
        helpImage.SetActive(false);
        helpMenuIsActive = false;
    }

    public void openHelpMenu()
    {
        //helpButton.SetActive(false);
        helpImage.SetActive(true);
        helpMenuIsActive = true;
  
    }
}
