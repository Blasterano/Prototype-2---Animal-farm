using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    float topBound = 30.0f, lowerBound = -10.0f, horizontalBound = 45.0f;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        { 
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.SubtractLife(); // bonus
            Destroy(gameObject);
        }
        // bonus feature challenge
        if (transform.position.x > horizontalBound)
        {
            Destroy(gameObject);
            gameManager.SubtractLife();
        }
        else if (transform.position.x < -horizontalBound)
        {
            Destroy(gameObject);
            gameManager.SubtractLife();
        }

    }
}
