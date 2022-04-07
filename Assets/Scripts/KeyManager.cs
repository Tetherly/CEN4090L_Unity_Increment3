using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public AudioSource MissedNote;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "notes")
        {
            //Debug.Log("This happened!");
            if(gameObject.name == "PianoKeyC4")
            {
                if (Input.GetKey(KeyCode.CapsLock))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }else if(gameObject.name == "PianoKeyD4")
            {
                if (Input.GetKey(KeyCode.A))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyE4")
            {
                if (Input.GetKey(KeyCode.S))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyF4")
            {
                if (Input.GetKey(KeyCode.D))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyG4")
            {
                if (Input.GetKey(KeyCode.F))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyA4")
            {
                if (Input.GetKey(KeyCode.G))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyB4")
            {
                if (Input.GetKey(KeyCode.H))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyC5")
            {
                if (Input.GetKey(KeyCode.J))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyD5")
            {
                if (Input.GetKey(KeyCode.K))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyE5")
            {
                if (Input.GetKey(KeyCode.L))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyF5")
            {
                if (Input.GetKey(KeyCode.Semicolon))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyG5")
            {
                if (Input.GetKey(KeyCode.Quote))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyA5")
            {
                if (Input.GetKey(KeyCode.Return))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyDb4")
            {
                if (Input.GetKey(KeyCode.Q))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyEb4")
            {
                if (Input.GetKey(KeyCode.W))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyGb4")
            {
                if (Input.GetKey(KeyCode.R))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyAb4")
            {
                if (Input.GetKey(KeyCode.T))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyBb4")
            {
                if (Input.GetKey(KeyCode.Y))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyDb5")
            {
                if (Input.GetKey(KeyCode.I))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyEb5")
            {
                if (Input.GetKey(KeyCode.O))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyGb5")
            {
                if (Input.GetKey(KeyCode.LeftBracket))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }
            else if (gameObject.name == "PianoKeyAb5")
            {
                if (Input.GetKey(KeyCode.RightBracket))
                {
                    //  increment score
                    ScoreScript.scoreValue += 10;
                }
                else
                {
                    // Play Missed Note Sound
                    //MissedNote.Play();
                }
            }

            Destroy(collision.gameObject);
        }
    }

}
