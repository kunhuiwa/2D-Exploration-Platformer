using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public GameObject KeyAppear;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
        GameObject Key = GameObject.FindWithTag("Key");
        KeyAppear.SetActive(false);
        Debug.Log("The key is hidden");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ScoreManager.coinAmount == 5)
        {
            if (collision.CompareTag("Player"))
            {
                Debug.Log("The key is shown!");
                KeyAppear.SetActive(true);
            }
        }
    }
}
