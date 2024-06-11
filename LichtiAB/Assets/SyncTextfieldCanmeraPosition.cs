using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SyncTextfieldCanmeraPosition : MonoBehaviour
{
    public Camera mainCamera;
    public List<TMP_Text> textFields;
     void Update(){
     foreach (TMP_Text textField in textFields)
    {
        Vector3 bottomScreenPos = new Vector3(0.5f, 0.05f, mainCamera.nearClipPlane); // Position am unteren Rand des Bildschirms
        Vector3 worldPos = mainCamera.ViewportToWorldPoint(bottomScreenPos);
        worldPos.z = 0; // Setze die Z-Koordinate auf 0 für 2D-Spiele
        textField.transform.position = worldPos;
    }
     }
}
