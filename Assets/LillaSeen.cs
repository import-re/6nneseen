using UnityEngine;

public class LillaSeen : MonoBehaviour
{
    public int lillaSeenHealth;
    void Start()
    {
        gameObject.SetActive(true);
        lillaSeenHealth = 9;
    }
}
