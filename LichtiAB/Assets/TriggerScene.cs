using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScene : MonoBehaviour
{
    SceneController sceneController;
     private void Awake() {
        sceneController = GetComponent<SceneController>();
    }
     void OnTriggerEnter2D(Collider2D other) {
         sceneController.LoadPopupScene();
    }
}
