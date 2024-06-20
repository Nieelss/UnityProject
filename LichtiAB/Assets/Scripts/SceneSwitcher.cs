using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{

    public string topDownSceneName = "Level1"; // Name der Top-Down-Szene

    public void SwitchBackToOriginalScene()
    {
        // Laden der gespeicherten Szene aus der SceneData-Klasse
        SceneManager.LoadScene(SceneData.returnSceneName);
    }

}
