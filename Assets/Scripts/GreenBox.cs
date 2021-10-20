using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBox : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Check if we have collided with the enemy
        if (coll.gameObject.tag == "GreenBox")
        {
            Destroy(gameObject);
        }
    }
} 