using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPhysicsMove : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0));
    }
}
