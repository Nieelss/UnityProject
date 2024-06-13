using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InputHandler : MonoBehaviour
{
    //referenz aus inputfield
    [SerializeField] InputField inputField;
    //textfeld referenz
    [SerializeField] TMP_Text resultText;

    public GameObject antwortText;

    public GameObject text;
    
    //spieler gameobject
    public GameObject player;
    //playermovement ist das skript in dem nachher der canenter bool geändert werden soll
    private PlayerMovement playerMovement;

    public GameObject a;
    private InteractionWardrobe interactionWardrobe;

   
    void Start()
    {   
        
        //text aktiviert --> nein
            resultText.enabled = false;  
        //skript zuweisung von player object auf die variable      
            playerMovement = player.GetComponent<PlayerMovement>();
       interactionWardrobe = a.GetComponent<InteractionWardrobe>();
       
    }
   
    //überprüfung der eingabe
    public void ValidateInput(){
        //mit inputfield.text bekommt man den text in form eines strings und das weise ich der input variable zu
        string input = inputField.text;
          
          
        if(input == "Georg Ridinger"){
            resultText.text = "Sehr gut, Richtige Antwort!";
            resultText.color = Color.green;
            Debug.Log("if else funktioniert");
            resultText.enabled = true;
            playerMovement.setBool();
            playerMovement.SetCanMove(true);
            interactionWardrobe.HideUI();
            interactionWardrobe.SetPopupTextVisibility(false);
            Debug.Log(resultText.enabled);
        }
        else{
          
            Debug.Log("else funktioniert");
            resultText.text = "Schade, die Antwort war leider falsch. Versuche es erneut";
            resultText.color = Color.red;
            interactionWardrobe.SetPopupTextVisibility(false);
            resultText.enabled = true;
            Debug.Log("Status des textfeldes" + resultText.enabled);
                    }

    }
  
}
