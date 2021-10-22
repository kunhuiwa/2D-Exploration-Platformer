using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

    public class Dialog : MonoBehaviour
    {
        public TextMeshProUGUI textDisplay;
        public string[] sentences;
        private int index;
        public float typingSpeed;

        public GameObject continueButton;

        void Start()
        {
            StartCoroutine(Type());
        }

        void Update()
        {
            if (textDisplay.text == sentences[index])
            {
                continueButton.SetActive(true);
            }
        }

        IEnumerator Type()
        {
            foreach (char letter in sentences[index].ToCharArray())
            {
                textDisplay.text += letter;
                yield return new WaitForSeconds(0.02f);

            }
        }

        public void NextSentence()
        {
            continueButton.SetActive(false);

            if (index < sentences.Length - 1)
            {
                index++;
                textDisplay.text = "";
                StartCoroutine(Type());
            }
            else
            {
                textDisplay.text = "";
                continueButton.SetActive(false);
            }
        }

    /*
public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public bool playerInRange;

    void Start() 
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && playerInRange)
        {
            StartCoroutine(Type());
        }
        else
        {
            index = 0;
        }

        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);

        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player in RANGE");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player out of RANGE");
            playerInRange = false;
        }
    }

*/


}