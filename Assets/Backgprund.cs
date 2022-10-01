using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgprund : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y != 13.22)
            {
                transform.position = new Vector3(transform.position.x, 13.22f, 0);
            }
    }
}
