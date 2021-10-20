using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float dirY;
    private float moveSpeed;
    private Rigidbody2D rb;
    private bool facingDowm = true;
    private Vector3 localScale;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirY = -1f;
        moveSpeed = 4f;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Check if we have collided with the enemy
        if (coll.gameObject.tag == "Ground")
        {
            dirY *= -1f;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, dirY * moveSpeed);
    }
} 
