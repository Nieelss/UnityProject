using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectionEnemy : MonoBehaviour
{
      public float gameOverDelay = 4f;
    private Coroutine countdownCoroutine;
    public GameObject spriteWarningSign;
    public void Start(){
        spriteWarningSign.SetActive(false);
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            spriteWarningSign.SetActive(true);
              Debug.Log("Player entered trigger!");
            countdownCoroutine = StartCoroutine(GameOverCountdown());
        }
    }
    private void OnTriggerExit2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        Debug.Log("Player exited trigger!");
        spriteWarningSign.SetActive(false);
        if (countdownCoroutine != null)
        {
            StopCoroutine(countdownCoroutine);
        }
    }
}
 
    IEnumerator GameOverCountdown()
    {
        
        yield return new WaitForSeconds(gameOverDelay);

        SceneManager.LoadScene("GameOver");
        Debug.Log("Game Over!");

       
    }
}
