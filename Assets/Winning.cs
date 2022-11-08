using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    GameObject[] gameObjects;
    void Update()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Boss");
        if (gameObjects.Length == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
