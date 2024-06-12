using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityInput : MonoBehaviour
{
  public GameObject input;

  void Awake() {
        input.SetActive(false);
  } 

  void SetVisibility(bool isVisible){
     input.SetActive(isVisible);
  }
}
