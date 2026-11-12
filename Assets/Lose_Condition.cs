using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose_Condition : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            audioSource.Play();
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
}