using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string popupSceneName = "MiniGame"; // Name der Popup-Szene

    // Methode zum Laden der Popup-Szene
    public void LoadPopupScene()
    {
        SceneManager.LoadScene(popupSceneName, LoadSceneMode.Additive);
         AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();
            if (audioListeners.Length > 1)
            {
                for (int i = 1; i < audioListeners.Length; i++)
                {
                    audioListeners[i].enabled = false; // oder Destroy(audioListeners[i]);
                }
            }
    }

    // Methode zum Entladen der Popup-Szene
    public void UnloadPopupScene()
    {
        SceneManager.UnloadSceneAsync(popupSceneName);
    }
}