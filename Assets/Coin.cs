using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Game_Manager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<Game_Manager>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GM.AddScore();
            Destroy(gameObject);
        }
    }
}
