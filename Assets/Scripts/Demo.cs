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
        if (Input.GetKey(KeyCode.CapsLock) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.G) || Input.GetKey(KeyCode.H) || Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.L) || Input.GetKey(KeyCode.Semicolon) || Input.GetKey(KeyCode.Quote) || Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.T) || Input.GetKey(KeyCode.Y) || Input.GetKey(KeyCode.I) || Input.GetKey(KeyCode.O) || Input.GetKey(KeyCode.LeftBracket) || Input.GetKey(KeyCode.RightBracket))
        {
            scoreTracker.ScoreTracker += 1;
        }
    }
    
}
