using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset =1f;
    public Transform target;
    //private float _fixedHeight;
    //public Transform target;

    void Start()
    {
        target = GameObject.Find("Player").transform;
        //_fixedHeight = transform.position.y;
    }


    void Update()
    {

        var yAxis = new Dictionary<string, float>()
        {
            { "Level1", 0.67f },
            { "Level2", 0.67f },
            { "Level3", 0.67f }
        };

        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
  
        float _fixedHeight;
        if (yAxis.TryGetValue(sceneName, out _fixedHeight))
        {
            Vector3 newPos = new Vector3(target.position.x,_fixedHeight,-10f);
            transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed*Time.deltaTime);
            //Debug.Log(transform.position);
        }
        else
        {
            Debug.Log($"scene name is invalid {sceneName}");
        }
    }
}
