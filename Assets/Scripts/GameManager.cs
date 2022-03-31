using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int counter = 0;

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementScore()
    {
        counter++;
        scoreText.text = "Score: " + counter;
    }
}
