using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
            ScoreManager.coinAmount += 1;
            Destroy(gameObject);
            Debug.Log("Collected a Seed");
    }
}
