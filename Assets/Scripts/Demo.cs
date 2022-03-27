using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    ScoreScript scoreTracker;
    public KeyCode changeScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreTracker = FindObjectOfType<ScoreScript>();
        scoreTracker.ScoreTracker = PlayerPrefs.GetInt("scoreTracker", 0);
        scoreTracker.ScoreTracker = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            scoreTracker.ScoreTracker += 100;
        }
    }
    
}
