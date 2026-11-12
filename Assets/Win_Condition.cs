using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Condition : MonoBehaviour
{
    public int totalCoins;
    // Start is called before the first frame update
    void Start()
    {
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    public void AddScore()
    {
        AddScore++;
        scoreText.text = "Score: " + score;
    }

    if (score==totalCoins)
        {
        Debug.Log("You Win!")
        Time.timeScale = 0;
        }
}