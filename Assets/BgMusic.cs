using UnityEngine;

public class BgMusic : MonoBehaviour
{
    public AudioSource Level1;

    void Update()
    {
        if ((Input.GetKeyUp("h") | Input.GetKeyDown(KeyCode.Escape)) & gameObject.activeInHierarchy)
        {
            Level1.Play();
        }
    }
}
