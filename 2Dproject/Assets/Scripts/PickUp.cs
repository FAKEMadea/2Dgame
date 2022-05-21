using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PickUp : MonoBehaviour
{
    public int score;
    public GameObject scoreText;

    void Start()
    {
        score = 0;
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
    
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            score++;
            scoreText.GetComponent<Text>().text = "Score: " + score;
            Destroy(collision.gameObject);
        }
    }
}
