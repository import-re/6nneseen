using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundaries 
{
    public int xStart {get; set;}
    public int xEnd {get; set;}

    public Boundaries(int _xStart, int _xEnd)
    {
        this.xStart = _xStart;
        this.xEnd = _xEnd;
    }
}

public class GameBoundaries : MonoBehaviour
{
    void Update()
    {
        var bound = new Dictionary<string, Boundaries>()
        {
            { "Level1", new Boundaries(114, 0)},
            { "Level2", new Boundaries(277, 97)},
            { "Level3", new Boundaries(351, 267)},
            {"BossScene", new Boundaries(395, 338)}
        };

        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        Boundaries b;
        if(bound.TryGetValue(sceneName, out b))
        {
            if(transform.position.x >= b.xStart)
            {
                transform.position = new Vector3(b.xStart, transform.position.y, 0);
            }
            if(transform.position.x < b.xEnd)
            {
                transform.position = new Vector3(b.xEnd, transform.position.y, 0);
            }
        }
        else
        {
            Debug.Log("Level is invalid " + sceneName);
        }
    }
}
