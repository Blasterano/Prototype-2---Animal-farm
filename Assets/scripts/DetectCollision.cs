using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(CompareTag("Player"))
        {
            gameManager.SubtractLife();
        }
        else
        {
            Destroy(gameObject);
            other.GetComponent<HungerBar>().FeedAnimal(1);
        }
        
    }
}
