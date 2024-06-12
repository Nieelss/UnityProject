using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rbody;
    private Vector2 _movement;
    private LichtiAB playerActions;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        _movement = value.Get<Vector2>();
    }
    private void FixedUpdate()
    {
        rbody.velocity =  _movement * speed;
    }
}