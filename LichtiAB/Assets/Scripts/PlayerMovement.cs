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
    public bool canMove = true;

    public bool canEnter;
   

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        if (canMove)
        {
            _movement = value.Get<Vector2>();
            if (_movement.x != 0 || _movement.y != 0)
            {
                animator.SetFloat("X", _movement.x);
                animator.SetFloat("Y", _movement.y);
            }
            else
            {
                animator.SetFloat("X", 0);
                animator.SetFloat("Y", 0);
            }
        }
        else
        {
            _movement = Vector2.zero;
            animator.SetFloat("X", 0);
            animator.SetFloat("Y", 0);
        }
    }
    private void FixedUpdate()
    {
         if (canMove)
        {
       rbody.MovePosition(rbody.position + _movement * speed * Time.fixedDeltaTime);
        }
    }
      public void SetCanMove(bool value)
    {
        canMove = value;
    }
   public void setBool()
   {    
        Debug.Log("Ich werde aufgerufen-setBool");
         canEnter = true;
    }
}