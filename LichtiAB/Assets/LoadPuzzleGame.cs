using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadPuzzleGame : MonoBehaviour
{
 public void SwitchToPuzzleScene(Vector3 playerPosition)
{
    // Speichern der Spielerposition und der aktuellen Szene
    SceneData.playerPosition = playerPosition;
    SceneData.SetReturnScene(SceneManager.GetActiveScene().name);

    // Laden der Puzzle-Szene
    SceneManager.LoadScene("MiniGame");
}
}
