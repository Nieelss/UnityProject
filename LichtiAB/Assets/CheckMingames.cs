using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMingames : MonoBehaviour
{
    public GameObject character;
    private CounterScenes counterScenes;
    public void Awake(){
        counterScenes = character.GetComponent<CounterScenes>();
    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            checkIfMiniGamesPlayed();
        }
    }
    
    public void checkIfMiniGamesPlayed(){
        if(counterScenes.gameScenesLoaded >= 9){
            Debug.Log("Game finished");
        }else{
            Debug.Log("Game not finished");
        }
    }
}
