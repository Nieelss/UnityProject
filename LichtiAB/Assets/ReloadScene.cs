using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        // Die aktuelle Szene ermitteln
        Scene currentScene = SceneManager.GetActiveScene();
        // Die aktuelle Szene neu laden
        SceneManager.LoadScene(currentScene.name);
    }
}
