using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlScript : MonoBehaviour
{
    CharacterController cc;
    public float gravity = -9.81f;
    public float gravityScale = 1;
    public float moveSpeed = 3;
    public float jumpHeight = 4;
    public float distanceToCheck = 0.5f;
    float velocity;
    bool isGrounded;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity = Mathf.Sqrt(jumpHeight * -2f * (gravity * gravityScale));
        }
        velocity += gravity * gravityScale * Time.deltaTime;
        if (isGrounded && velocity < 0) velocity = 0;
        cc.Move(new Vector2(Input.GetAxis("Horizontal") * moveSpeed, velocity) * Time.deltaTime);
        GroundCheck();
        if (isGrounded) Debug.Log("true");
        else Debug.Log("false");
        
    }

    void GroundCheck()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, distanceToCheck, LayerMask.GetMask("Floor"))) isGrounded = true;
        else isGrounded = false;
        Debug.DrawRay(transform.position, Vector2.down * distanceToCheck);
    }
}
