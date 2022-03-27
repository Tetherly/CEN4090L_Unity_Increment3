using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScoreScript : MonoBehaviour
{
    //[SerializeField} TextMesh TextScoreUI;
    [SerializeField] TextMesh Score_TextMesh;
    private int _scr;
    public int ScoreTracker
    {
        get { return _scr; }
        set
        {
            _scr = value;
            //scoreIncrement();
            //Score_TextMesh.text = "Score: " + ScoreTracker.ToString();
            //Score_TextMesh = GetComponent<TextMesh>();
            Score_TextMesh.text =  ScoreTracker.ToString();
            //ScoreTracker = 0;
            PlayerPrefs.SetInt("scoreTracker", ScoreTracker);
        }
    }

    //public Text scoreUI;
    //public KeyCode changeScore;




    // Start is called before the first frame update
    /*void Start()
    {
        TextScoreUI = GetComponent<Text>();
        scoreTracker = 0;
        TextScoreUI.text = "Score: " + scoreTracker.ToString();

        //scoreIncrement();

    }

    // Update is called once per frame
     void Update()
     {
         if (Input.GetKey(changeScore))
         {
             scoreIncrement();
         }

     }/*


     /*private void OnCollisionEnter2D(Collision2D collision)
     {
         //if (collision.gameObject.tag.Equals("NoteSpawner"))
         //{
             ScoreScript.scoreTracker += 100;
         //}
     }
     */
    /*
    void scoreIncrement()
    {
        TextScoreUI = GetComponent<Text>();
        TextScoreUI.text = "Score: " + scoreTracker.ToString();
        scoreTracker += 100;

    }
    */

}
    
