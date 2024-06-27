using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMiniGames : MonoBehaviour
{
    public GameObject character;
    private CounterScenes counterScenes;

    public void Awake()
    {
        counterScenes = character.GetComponent<CounterScenes>();
        Debug.Log("CheckMiniGames: CounterScenes component found");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");
            checkIfMiniGamesPlayed();
        }
    }

    public void checkIfMiniGamesPlayed()
    {
        if (counterScenes.gameScenesLoaded >= 9)
        {
            Debug.Log("Game finished");
        }
        else
        {
            Debug.Log("Game not finished, current count: " + counterScenes.gameScenesLoaded);
        }
    }
}