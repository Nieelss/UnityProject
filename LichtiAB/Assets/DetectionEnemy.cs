using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionEnemy : MonoBehaviour
{
      public float gameOverDelay = 4f;
    private Coroutine countdownCoroutine;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
              Debug.Log("Player entered trigger!");
            countdownCoroutine = StartCoroutine(GameOverCountdown());
        }
    }
    private void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
        Debug.Log("Player exited trigger!");
        
        if (countdownCoroutine != null)
        {
            StopCoroutine(countdownCoroutine);
        }
    }
}
 
    IEnumerator GameOverCountdown()
    {
        
        yield return new WaitForSeconds(gameOverDelay);

        
        Debug.Log("Game Over!");

       
    }
}
