using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadChest : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public GameObject badchest;

    // Start is called before the first frame update
    private void Awake()
    {
        //circleCollider = GetComponent<CircleCollider2D>();
        //circleCollider.isTrigger = true;
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
        GameObject Key = GameObject.FindWithTag("Player");
        badchest.SetActive(false);
        Debug.Log("The CHEST IS CLOSED");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("The BADCHEST IS OPENED!");
            badchest.SetActive(true);
        }
    }
}