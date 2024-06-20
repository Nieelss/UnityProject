using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
   public string sceneToLoad = "MiniGame"; 
   public LoadPuzzleGame load;
   void Start(){
    load = GetComponent<LoadPuzzleGame>();
   }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           

           
           
            
                load.SwitchToPuzzleScene(transform.position); 
            
           
    }
    }
}
