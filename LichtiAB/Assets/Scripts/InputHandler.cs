using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] TMP_Text resultText;

    public GameObject player;
    private PlayerMovement playerMovement;
    void Start()
    {
            resultText.enabled = false;        
            playerMovement = player.GetComponent<PlayerMovement>();
            
    }
    
    public void ValidateInput(){
        string input = inputField.text;
        if(input == "Georg Ridinger"){
            resultText.text = "Sehr gut, Richtige Antowrt!";
            resultText.color = Color.green;
            playerMovement.setBool();

        }
        else{
            resultText.text = "Schade, die Antwort war leider falsch. Versuche es erneut";
            resultText.color = Color.red;
        }

    }
}
