using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionEnemy : MonoBehaviour
{
      public float gameOverDelay = 4f;

    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            StartCoroutine(GameOverCountdown());
        }
    }

 
    IEnumerator GameOverCountdown()
    {
        
        yield return new WaitForSeconds(gameOverDelay);

        
        Debug.Log("Game Over!");

       
    }
}
