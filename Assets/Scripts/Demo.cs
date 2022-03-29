using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    ScoreScript scoreTracker;
    public KeyCode changeScore;
    static int count;
    // Start is called before the first frame update
    void Start()
    {
        scoreTracker = FindObjectOfType<ScoreScript>();
        scoreTracker.ScoreTracker = PlayerPrefs.GetInt("scoreTracker", 0);
        scoreTracker.ScoreTracker = 0;

        scoreTracker.HighScoreTracker = PlayerPrefs.GetInt("HighScoreTracker", 0);
        scoreTracker.HighScoreTracker = 0;  
    }

    // Update is called once per frame
    void Update()
    {

    }


    protected void IncrementScore()
    {
        scoreTracker.ScoreTracker += 1;
        count = scoreTracker.ScoreTracker;
        scoreTracker.HighScoreTracker = count;
    }

}
