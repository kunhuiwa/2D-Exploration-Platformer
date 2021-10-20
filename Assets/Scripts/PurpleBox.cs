using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBox : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        // Check if we have collided with the enemy
        if (coll.gameObject.tag == "PurpleBox")
        {
            Destroy(gameObject);
        }
    }
} 

/*
    public BoxCollider2D boxCollider;
    public GameObject TrapDoor;

    // Start is called before the first frame update
    private void Awake()
    {
        //circleCollider = GetComponent<CircleCollider2D>();
        //circleCollider.isTrigger = true;
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
        GameObject Key = GameObject.FindWithTag("PurpleBox");
        TrapDoor.SetActive(true);
        Debug.Log("The CHEST IS CLOSED");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("The BADCHEST IS OPENED!");
            TrapDoor.SetActive(false);
        }
    }
}
*/