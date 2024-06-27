using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounterTigger : MonoBehaviour
{
      public GameObject otherGameObject;
     private CounterScenes counterScenes;
     void Awake(){
        counterScenes = otherGameObject.GetComponent<CounterScenes>();
     }
     void OnTriggerEnter2D(Collider2D other) {
        
        counterScenes.sceneCounter();
        Debug.Log("Feld betreten");
    }
}
