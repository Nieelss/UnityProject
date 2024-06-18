using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRoomName : MonoBehaviour
{
   
    public GameObject room1;
  
    public float displayTime = 3.0f;

   void Start()
    {
       room1.SetActive(false);
        StartCoroutine(ShowAndHide());
    }

    IEnumerator ShowAndHide()
    {
        
        room1.SetActive(true);
       
        yield return new WaitForSeconds(displayTime);
       
        room1.SetActive(false);
    }
    
}
