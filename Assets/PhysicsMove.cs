using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMove : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb2.velocity.y);
    }
}
