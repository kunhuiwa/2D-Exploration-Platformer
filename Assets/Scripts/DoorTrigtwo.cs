using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigtwo : MonoBehaviour
{ 
    public BoxCollider2D boxCollider;
    public GameObject Door;
    Vector3 newPos = new Vector3(1f, -13f, 0f);
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;

    // Start is called before the first frame update
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.red;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("The player has opened the door", gameObject);
            Door.transform.position = newPos;
            m_SpriteRenderer.color = Color.green;
        }
    }
}