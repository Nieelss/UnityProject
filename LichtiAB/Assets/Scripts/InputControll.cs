using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControll : MonoBehaviour
{
    public bool acceptInput = true; // Variable, um Eingaben zu steuern

    void Update()
    {
        if (acceptInput)
        {
            ProcessInput();
        }
    }

    void ProcessInput()
    {
        // Hier kommt deine normale Eingabelogik
        if (Input.GetKey(KeyCode.W))
        {
            // Bewege Spieler nach vorne
        }
       
    }

    public void EnableInput(bool enable)
    {
        acceptInput = enable;
    }
    
}
