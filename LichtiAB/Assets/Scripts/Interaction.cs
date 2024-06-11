using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Interaction : MonoBehaviour
{
 private BoxCollider2D bC2d;

public GameObject popupText;
public GameObject popupText2;
public Playeractions playerAction;
private InputAction interact;
public bool isInside = false;



 
void Awake()
{
    bC2d = GetComponent<BoxCollider2D>();
    
    HidePopupText();
    playerAction = new Playeractions();
        HidePopupText2();

}
void OnTriggerExit2D(Collider2D other)
 {
    if(other.CompareTag("Player") ){
        
        HidePopupText();
        Debug.Log("Zone verlassen");
        HidePopupText2();
        isInside = false;
    }
}


 void OnTriggerEnter2D(Collider2D other) 
 {
    if(other.CompareTag("Player")){
        Debug.Log("Worked");
        ShowPopupText2();
        isInside = true;
    }
 }
 void OnInteract(InputValue value)
{
     if(value.isPressed && isInside ) {
        Debug.Log("Funktiniert");
        ShowPopupText();
        HidePopupText2();
     }      
  
}


void HidePopupText()
{
    popupText.SetActive(false);
}
void ShowPopupText()
{

    popupText.SetActive(true);
}
void ShowPopupText2()
{
    
    popupText2.SetActive(true);
}
void HidePopupText2()
{
    popupText2.SetActive(false);
}
    
}
