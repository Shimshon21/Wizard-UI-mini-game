using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public void loadLevel(string levelName)
    {
        Debug.Log("Level load requested for " + levelName);
        Application.LoadLevel(levelName);
    }
    public void quitRequest()
    {
        Debug.Log("Exit from game thanks for playing!");
        Application.Quit();
    }
	
}
