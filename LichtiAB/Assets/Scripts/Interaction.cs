using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Interaction : MonoBehaviour
{
 private BoxCollider2D bC2d;


public GameObject popupText2;
public GameObject popupText;


public Playeractions playerAction;
private InputAction interact;
public bool isInside = false;

//private CheckDoor checkDoor;


 
void Awake()
{
    bC2d = GetComponent<BoxCollider2D>();
    SetPopupTextVisibility2(false);
    SetPopupTextVisibility(false);
    playerAction = new Playeractions();
    
    

}
void OnTriggerExit2D(Collider2D other)
 {
    if(other.CompareTag("Player") ){
      
        SetPopupTextVisibility(false);
        Debug.Log("Zone verlassen");
        SetPopupTextVisibility2(false);
        isInside = false;
    }
}


 void OnTriggerEnter2D(Collider2D other) 
 {
    if(other.CompareTag("Player")){
        Debug.Log("Worked");
        SetPopupTextVisibility2(true);
        isInside = true;
        //checkDoor.checkEnter();
    }
 }
 void OnInteract(InputValue value)
{
     if(value.isPressed && isInside ) {
        Debug.Log("Funktiniert");
        SetPopupTextVisibility(true);
        SetPopupTextVisibility2(false);
        
     }      
  
}



void SetPopupTextVisibility(bool isVisible)
{
    popupText.SetActive(isVisible);
}
void SetPopupTextVisibility2(bool isVisible)
{
    
    popupText2.SetActive(isVisible);
}
    
}
