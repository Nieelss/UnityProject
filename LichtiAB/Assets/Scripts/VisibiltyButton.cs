using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityButton : MonoBehaviour
{
  public GameObject button;

  void Awake() {
        button.SetActive(false);
  } 

  void SetVisibility(bool isVisible){
     button.SetActive(isVisible);
  }
}
