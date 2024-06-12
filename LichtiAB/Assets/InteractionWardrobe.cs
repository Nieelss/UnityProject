using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InteractionWardrobe : MonoBehaviour
{
private BoxCollider2D bC2d;

public GameObject popupText2;
public GameObject popupText;

public GameObject inputField;
public GameObject button;

public Playeractions playerAction;
private InputAction interact;
private InputHandler inputHandler;
public bool isInside = false;



 
void Awake()
{
    bC2d = GetComponent<BoxCollider2D>();
    SetPopupTextVisibility2(false);
    SetPopupTextVisibility(false);
    playerAction = new Playeractions();
    inputHandler = button.GetComponent<InputHandler>();
    

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
    }
 }
 void OnInteract(InputValue value)
{
     if(value.isPressed && isInside ) {
        Debug.Log("Funktiniert");
        SetPopupTextVisibility(true);
        SetPopupTextVisibility2(false);
        inputField.SetActive(true);
        button.SetActive(true);
        inputHandler.ValidateInput();
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