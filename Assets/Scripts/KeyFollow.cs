using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFollow : MonoBehaviour
{
    private bool isFollowing;
    public float followSpeed;

    public Transform followTarget;

    // Start is called before the first frame update
    void Start()
    {
        isFollowing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isFollowing = true;
            Debug.Log("Player has the Key");
            //thePlayer.followingKey = this;
        }
        
        if (collision.CompareTag("Chest"))
        {
             Debug.Log("The Key is used");
             Destroy(gameObject);
        }

    }
} 

