using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic : MonoBehaviour
{
    public AudioSource Level1;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyUp("h") | Input.GetKeyDown(KeyCode.Escape)) & gameObject.activeInHierarchy)
        {
            Level1.Play();
        }
    }
}
