using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1;
    public float speed = 3;
    public Rigidbody2D rb;
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float moveHorizontal = 0;
        float moveVertical = 0;

        if (player1)
        {
            moveVertical = Input.GetAxisRaw("Vertical2");
            moveHorizontal = Input.GetAxisRaw("Horizontal2");
        }
        else
        {
            moveVertical = Input.GetAxisRaw("Vertical");
            moveHorizontal = Input.GetAxisRaw("Horizontal");
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
