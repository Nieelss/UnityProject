using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputValidation : MonoBehaviour
{
    public TMP_Text popup;
    public TMP_Text feedbackText;
    public TMPro.TMP_InputField inputField;

    public GameObject character;
    private PlayerMovement playerMovement;
    public string requiredSentence = "Georg Ridinger";

    public bool isInside = false;


    void Awake(){
        PlayerMovement playerMovement = character.GetComponent<PlayerMovement>();
        HideText();
         inputField.onEndEdit.AddListener(ValidateInput);
         inputField.gameObject.SetActive(false);
         
    }


     void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
             Debug.Log("Exit");
             popup.gameObject.SetActive(false);
        }
    }


     void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            Debug.Log("Input field");
           popup.gameObject.SetActive(true);
           isInside = true;
        }
    }
  /*  void OnInteract(InputValue value)
{
     if(value.isPressed && isInside) {
        Debug.Log("Funktiniert");
        
     }      
  
}*/
     void ValidateInput(string userInput)
    {
        if (userInput == requiredSentence)
        {
            feedbackText.text = "Eingabe korrekt!";
            feedbackText.color = Color.green; // Grün für korrekt
        }
        else
        {
            feedbackText.text = "Falscher Satz. Bitte versuche es erneut.";
            feedbackText.color = Color.red; // Rot für falsch
        }
    }

    void HideText()
    {
        popup.gameObject.SetActive(false);
        feedbackText.gameObject.SetActive(false);
        inputField.gameObject.SetActive(false);
    }
        
    
    void ShowText(){
        popup.gameObject.SetActive(true);
        feedbackText.gameObject.SetActive(true);
    }
}
