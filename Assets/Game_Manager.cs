using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    AudioSource audioSource;
    public int totalCoins;
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score == totalCoins)
        {
            audioSource.Play();
            Debug.Log("You Win!");
            Time.timeScale = 0;
        }
    }
}
