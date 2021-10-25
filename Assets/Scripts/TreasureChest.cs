using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public GameObject Chest;

    // Start is called before the first frame update
    private void Awake()
    {
        //circleCollider = GetComponent<CircleCollider2D>();
        //circleCollider.isTrigger = true;
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
        GameObject Key = GameObject.FindWithTag("Key");
        Chest.SetActive(false);
        Debug.Log("The CHEST IS CLOSED");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key"))
        {
            Destroy(gameObject);
            Debug.Log("The CHEST IS OPENED!");
            Chest.SetActive(true);
        }
    }
} 