using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPhysicsJump : MonoBehaviour
{
    public float jumpingGravity;
    public float fallingGravity;
    public float jumpPower;
    public float distanceToCheck = 0.5f;
    public bool isGrounded;
    public float offset = 0.2f;

    float gravity = -9.81f;
    float velocity;


    void Start()
    {
        velocity = 0;
    }

    void Update()
    {
        if(velocity >= 0) velocity += gravity * jumpingGravity * Time.deltaTime;
        else if (velocity < 0) velocity += gravity * fallingGravity * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity = jumpPower;
        }
        GroundCheck();
        if (isGrounded && velocity < 0) velocity = 0;
        transform.Translate(new Vector2(0, velocity * Time.deltaTime));
    }

    void GroundCheck()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, distanceToCheck, LayerMask.GetMask("Floor"))) isGrounded = true;
        else isGrounded = false;
    }
    /*
    void GroundCheck()
    {
        Vector2 point = transform.position + Vector3.down * offset;
        Vector2 size = new Vector2(transform.localScale.x, transform.localScale.y);
        isGrounded = Physics2D.OverlapBox(point, size, 0);
    }
    */
}