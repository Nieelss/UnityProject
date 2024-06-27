using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScenes : MonoBehaviour
{
    public int gameScenesLoaded; // Start with 10 for testing
    public Text counterText;

    void Start()
    {
        UpdateCounterText();
    }

    public void sceneCounter()
    {
        gameScenesLoaded++;
        UpdateCounterText();
        Debug.Log("SceneCounter: gameScenesLoaded = " + gameScenesLoaded);
    }

    private void UpdateCounterText()
    {
        
        if (gameScenesLoaded < 10)
        {
            counterText.text = "MiniGames finished: " + gameScenesLoaded + "/9";
        }
        else
        {
            counterText.text = "Zeitmaschine betriebsbereit";
        }
    }
}

