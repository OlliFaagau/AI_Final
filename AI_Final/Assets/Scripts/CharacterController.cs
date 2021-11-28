using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Rigidbody2D body;
    Animator animator;
    Vector2 movement;

    public float runSpeed = 5.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(movement.x * runSpeed, movement.y * runSpeed);
    }
}
