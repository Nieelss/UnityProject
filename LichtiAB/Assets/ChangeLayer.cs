/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{
    public GameObject player;
    private PlayerMovement playerMovement;
    public void Awake()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }
    public void OnTriggerEnter2D(){
        checkEnter();
    }
   public void checkEnter(){
        bool isAllowed = playerMovement.canEnter; 
        if(isAllowed == true)
        {
            
        }
   }
}
*/