using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckDoor : MonoBehaviour
{
    public GameObject player;
    private PlayerMovement playerMovement;
    //private Animator animation;
    private BoxCollider2D boxCollider2D;
    public Sprite newSprite;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        //animation = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
         spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void checkEnter()
    {
    if(playerMovement.canEnter == true)
    {   
        Debug.Log("checkEnter wird aufgerufen");
         boxCollider2D.enabled = false;
        spriteRenderer.sprite = newSprite;
        
         
       // animation.SetTrigger("DoorTrigger");
        
    }
    }
}   
