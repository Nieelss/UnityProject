using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckMiniGames : MonoBehaviour
{
    public GameObject character;
    private CounterScenes counterScenes;
    public GameObject textfeld;

    public void Awake()
    {
        counterScenes = character.GetComponent<CounterScenes>();
        Debug.Log("CheckMiniGames: CounterScenes component found");
        textfeld.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");
            checkIfMiniGamesPlayed();
        }
    }
    public void OnTriggerExit2D(Collider2D other) {
        textfeld.SetActive(false);
    }

    public void checkIfMiniGamesPlayed()
    {
        if (counterScenes.gameScenesLoaded == 5)
        {   
           SceneManager.LoadScene("Zeitmaschine");
            Debug.Log("Game finished");
        }
        else
        {
            Debug.Log("Game not finished, current count: " + counterScenes.gameScenesLoaded);
             textfeld.SetActive(true);
        }
    }
}