using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft = 10.0f;
    public GameObject timerText;

    void Start()
    {
       
    }

    public void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {
            //timeLeft.GetComponent<Text>().text = "Time: " + timeLeft;
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}
