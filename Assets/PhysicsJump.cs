using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsJump : MonoBehaviour
{
    public float jumpHeight;
    public float jumpingGravity;
    public float fallingGravity;
    public float buttonTime = 0.3f;
    float jumpPower;
    float jumpTime;
    bool isRising;
    bool jumpCancelled;

    Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //4. Charge Jump with Exact Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPower = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb2.gravityScale));
            rb2.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            isRising = true;
            jumpCancelled = false;
            jumpTime = 0;
        }
        if (isRising)
        {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space)) jumpCancelled = true;
            if (jumpTime > buttonTime) isRising = false;
        }
        if (jumpCancelled && isRising && rb2.velocity.y > 0) rb2.AddForce(Vector2.down * 10, 0);
        if (rb2.velocity.y >= 0) rb2.gravityScale = jumpingGravity;
        else rb2.gravityScale = fallingGravity;
    }
}

/*
public class PhysicsJump : MonoBehaviour
{
    public float jumpPower;
    Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //1. Floaty Jump
        if(Input.GetKeyDown(KeyCode.Space))
            rb2.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }
}
*/

/*
public class PhysicsJump : MonoBehaviour
{
    public float jumpPower;
    public float jumpingGravity;
    public float fallingGravity;

    Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //2. Falling Speed Control
        if(Input.GetKeyDown(KeyCode.Space))
            rb2.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        if (rb2.velocity.y >= 0) rb2.gravityScale = jumpingGravity;
        else rb2.gravityScale = fallingGravity;
    }
}
*/

/*
public class PhysicsJump : MonoBehaviour
{
    public float jumpHeight;
    public float jumpingGravity;
    public float fallingGravity;
    float jumpPower;

    Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //3. Exact Height Jump
        jumpPower = Mathf.Sqrt(-2 * jumpHeight * (Physics2D.gravity.y * rb2.gravityScale));
        if (Input.GetKeyDown(KeyCode.Space))
            rb2.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        if (rb2.velocity.y >= 0) rb2.gravityScale = jumpingGravity;
        else rb2.gravityScale = fallingGravity;

    }
}
*/

/*
public class PhysicsJump : MonoBehaviour
{
    public float jumpHeight;
    public float jumpingGravity;
    public float fallingGravity;
    float jumpTime;
    float jumpPower;

    Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //4. Charge Jump with Exact Jump
        jumpPower = Mathf.Sqrt(-2 * jumpHeight * (Physics2D.gravity.y * rb2.gravityScale));
        if (Input.GetKeyDown(KeyCode.Space))
            jumpTime = 0;
        if (Input.GetKey(KeyCode.Space) && (jumpTime <= 1))
            jumpTime += Time.deltaTime*2;
        if (Input.GetKeyUp(KeyCode.Space))
            rb2.AddForce(new Vector2(0, jumpPower)*jumpTime, ForceMode2D.Impulse);
        if (rb2.velocity.y >= 0) rb2.gravityScale = jumpingGravity;
        else rb2.gravityScale = fallingGravity;
    }
}
*/

/*
public class PhysicsJump : MonoBehaviour
{
    public float jumpHeight;
    public float jumpingGravity;
    public float fallingGravity;
    public float buttonTime = 0.3f;
    float jumpPower;
    float jumpTime;
    bool isRising;
    bool jumpCancelled;

    Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //5. Variable Jump with Exact Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPower = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb2.gravityScale));
            rb2.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            isRising = true;
            jumpCancelled = false;
            jumpTime = 0;
        }
        if (isRising)
        {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space)) jumpCancelled = true;
            if (jumpTime > buttonTime) isRising = false;
        }
        if (jumpCancelled && isRising && rb2.velocity.y > 0) rb2.AddForce(Vector2.down * 10, 0);
        if (rb2.velocity.y >= 0) rb2.gravityScale = jumpingGravity;
        else rb2.gravityScale = fallingGravity;
    }
}
*/