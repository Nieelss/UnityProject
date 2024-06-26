using UnityEngine;
using UnityEngine.SceneManagement;

public class Unload1682 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ClickToHome()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToMap()
    {
        SceneManager.UnloadSceneAsync("1682");
    }
}
