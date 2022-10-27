using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenUDontDestroy : MonoBehaviour
{
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
