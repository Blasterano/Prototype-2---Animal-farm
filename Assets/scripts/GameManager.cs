using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int life = 10, score = 0;

    public TMP_Text[] ui;
    public GameObject gameOverText, player;
    // Start is called before the first frame update
    void Start()
    {
        ui[0].text = "Life :" + life;
        ui[1].text = "Score :" + score;
        //Debug.Log("Life: " + life + "Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubtractLife()
    {
        life -= 1;

        if (life<=0)
        {
            //Debug.Log("Game Over! ");
            Destroy(player.gameObject);
            gameOverText.SetActive(true);
            life = 0;
        }
        //Debug.Log("Life = " + life);
        ui[0].text = "Life :" + life;

    }

    public void AddScore()
    {
        score += 1;
        ui[1].text = "Score :" + score;
        //Debug.Log("Score = " + score);
    }
}
