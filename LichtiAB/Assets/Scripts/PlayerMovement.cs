using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rbody;
    private Vector2 _movement;
    private Animator animator;

    public bool canEnter;
   

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        _movement = value.Get<Vector2>();
        if(_movement.x != 0 || _movement.y != 0){
        animator.SetFloat("X", _movement.x);
        animator.SetFloat("Y", _movement.y);
       
        }else{
             animator.SetFloat("X", _movement.x);
            animator.SetFloat("Y", _movement.y);
        } 
    }
    private void FixedUpdate()
    {
       rbody.MovePosition(rbody.position + _movement * speed * Time.fixedDeltaTime);
       
    }
   public void setBool(bool b){
         canEnter = b;
    }
}