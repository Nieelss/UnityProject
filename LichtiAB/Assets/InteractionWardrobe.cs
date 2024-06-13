using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InteractionWardrobe : MonoBehaviour
{
private BoxCollider2D bC2d;
//Inspekt Popup
public GameObject popupText2;
//Interaktiver Text
public GameObject popupText;
//Das zu Referendierende InputField aber nur zum ein und ausblenden
public GameObject questionText;
public GameObject inputField;
//Der Button zum ein und ausblenden
public GameObject button;
public GameObject exitButton;

public GameObject player;
 private bool isInputFieldActive = false;

//public Playeractions playerAction;
//private InputAction interact;

//Skript des Buttons für die validierung der eingabe
private InputHandler inputHandler;
//Bool um zu prüfen ob Spieler innerhalb der zone ist
public bool isInside = false;



 //Hier wird Textfeld 1 und 2 unsichtbar gemacht und die Zuweisung der button Komponente zu der Skript Variable
 // button wird ebenfalls unsichtbar gemacht
void Awake()
{   

    bC2d = GetComponent<BoxCollider2D>();
    SetPopupTextVisibility2(false);
    SetPopupTextVisibility(false);
    //SetPopupTextVisibility3(false);
    //playerAction = new Playeractions();
    inputHandler = button.GetComponent<InputHandler>();
    button.SetActive(false);
    SetPopupTextVisibility3(false);
    SetexitButtonVisibility(false);
    }

    //Wenn der Spieler die zone verlässt 
void OnTriggerExit2D(Collider2D other)
 {
    //Überprüft auf Tag Player
    if(other.CompareTag("Player") ){
 //Text 1 und 2 unscihtbar machen     
        //SetPopupTextVisibility(false);
        SetPopupTextVisibility2(false);
        Debug.Log("Zone verlassen");
        //bool wird gesetzt
        isInside = false;
        SetButtonVisibility(false);
        //SetTextInputVisibility(false);
        SetPopupTextVisibility3(false);
        SetexitButtonVisibility(false);
        inputHandler.clearInput();

    }
}

//wenn spieler zone betritt
 void OnTriggerEnter2D(Collider2D other) 
 {
    //auf Tag geprüft
    if(other.CompareTag("Player")){
        Debug.Log("Worked");
        //Interatkive textfeld aktiviert
        SetPopupTextVisibility2(true);
        //bool auf true (spieler inside)
        isInside = true;
    }
 }
 //prüft den input oninteract (e)
 void OnInteract(InputValue value)
{
    //wenn e gepresst und spieler auch in der zone ist
     if(value.isPressed && isInside && !isInputFieldActive) {
        Debug.Log("Funktiniert");
        //interaktiver text angezeigt
       SetPopupTextVisibility(true);
        //Inspizieren verschwindet
        SetPopupTextVisibility2(false);
        //außerdem wird das input field und button angezeigt
        SetTextInputVisibility(true);
        SetButtonVisibility(true);
        //hier versuche ich auf die methode aus dem skript "inputhandler" zuzugreifen
        player.GetComponent<PlayerMovement>().SetCanMove(false);
        SetPopupTextVisibility3(true);
        SetexitButtonVisibility(true);

     }    
  
}
public void HideUI(){
   // SetPopupTextVisibility(false);
    SetButtonVisibility(false);
    SetTextInputVisibility(false);
    //SetPopupTextVisibility3(false);
    SetPopupTextVisibility2(false);
}


//visibility für interactive textfeld
public void SetPopupTextVisibility(bool isVisible)
{
    popupText.SetActive(isVisible);
}
//visibility für inspizieren
public void SetPopupTextVisibility2(bool isVisible)
{
        popupText2.SetActive(isVisible);
}
  public void SetPopupTextVisibility3(bool isVisible)
{
        questionText.SetActive(isVisible);
}   
public void SetButtonVisibility(bool isVisible)
{
        button.SetActive(isVisible);
}   
public void SetTextInputVisibility(bool isVisible)
{
        inputField.SetActive(isVisible);
         isInputFieldActive = isVisible; 
} 
public void SetexitButtonVisibility(bool isVisible)
{
        exitButton.SetActive(isVisible);
       
} 
}