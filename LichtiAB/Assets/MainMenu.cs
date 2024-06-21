using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
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
        SceneManager.LoadScene(2);
    }
}
