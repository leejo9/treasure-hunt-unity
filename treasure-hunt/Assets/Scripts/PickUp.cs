using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameBehaviour gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pick Up")
        {
            other.gameObject.SetActive(false);
            GetComponent<AudioSource>().Play();
            gameManager.Items += 1;
        }
    }
}
