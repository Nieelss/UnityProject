using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterScenes : MonoBehaviour
{
    int gameScenesLoaded = 0;
    public Text counterText; 
    public void sceneCounter(){
        gameScenesLoaded++;
        if(gameScenesLoaded < 10){
            counterText.text = "MiniGames finished: " + gameScenesLoaded + "/9";
         Debug.Log("SceneCounter");
        }else{
             counterText.text = "Zeitmaschine betriebsbereit";
        }
        
    }
}
