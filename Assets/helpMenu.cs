using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpMenu : MonoBehaviour
{
    //public Button helpButton;
    public GameObject helpImage;
    // Start is called before the first frame update
    void Start()
    {
        //helpButton.SetActive(true);
        helpImage.SetActive(false);
    }


    void Update()
    {
        if(Input.GetKeyUp("h"))
        {
            if (helpImage.activeInHierarchy)
            {
                closeHelpMenu();
            }
            else
            {
                openHelpMenu();
            }
        }
    }
    // Update is called once per frame
    public void closeHelpMenu()
    {
        //helpButton.SetActive(true);
        helpImage.SetActive(false);
    }

    public void openHelpMenu()
    {
        //helpButton.SetActive(false);
        helpImage.SetActive(true);
    }
}
