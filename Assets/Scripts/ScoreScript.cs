using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScoreScript : MonoBehaviour
{
    
    [SerializeField] TextMesh Score_TextMesh;
    private int _scr;
    public int ScoreTracker
    {
        get { return _scr; }
        set
        {
            _scr = value;
            Score_TextMesh.text =  ScoreTracker.ToString();
            PlayerPrefs.SetInt("scoreTracker", ScoreTracker);
        }
    }
    [SerializeField] TextMesh HighScore_TextMesh;
    private int _Hscr;
    public int HighScoreTracker
    {
        get { return _Hscr; }
        set
        {
            _Hscr = value;
            HighScore_TextMesh.text = HighScoreTracker.ToString();
            PlayerPrefs.SetInt("High Score", HighScoreTracker);
        }
    }

   

}
    
