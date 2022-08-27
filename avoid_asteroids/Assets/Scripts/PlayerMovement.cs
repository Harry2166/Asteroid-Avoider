using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float move_speed = 5f;
    public Rigidbody2D rb;
    //[SerializeField] private Animator anim;
    Vector2 movement;

    private void Update(){
        // input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //anim.SetFloat("Horizontal", movement.x);
        //anim.SetFloat("Vertical", movement.y);
        //anim.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate(){
        // movement
        rb.MovePosition(rb.position + movement * move_speed * Time.fixedDeltaTime);
    }
}
