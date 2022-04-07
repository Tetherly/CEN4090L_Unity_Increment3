using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    GameManager gm;

    public AudioSource MissedNote;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "notes")
        {
            if(collision.gameObject.name == "NoteC4" && gameObject.name == "PianoKeyC4")
            {
                if (Input.GetKeyDown(KeyCode.CapsLock))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }else if(collision.gameObject.name == "NoteD4" && gameObject.name == "PianoKeyD4")
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteE4" && gameObject.name == "PianoKeyE4")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteF4" && gameObject.name == "PianoKeyF4")
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteG4" && gameObject.name == "PianoKeyG4")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteA4" && gameObject.name == "PianoKeyA4")
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteB4" && gameObject.name == "PianoKeyB4")
            {
                if (Input.GetKeyDown(KeyCode.H))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteC5" && gameObject.name == "PianoKeyC5")
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteD5" && gameObject.name == "PianoKeyD5")
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteE5" && gameObject.name == "PianoKeyE5")
            {
                if (Input.GetKeyDown(KeyCode.L))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteF5" && gameObject.name == "PianoKeyF5")
            {
                if (Input.GetKeyDown(KeyCode.Semicolon))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteG5" && gameObject.name == "PianoKeyG5")
            {
                if (Input.GetKeyDown(KeyCode.Quote))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteA5" && gameObject.name == "PianoKeyA5")
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteDb4" && gameObject.name == "PianoKeyDb4")
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteEb4" && gameObject.name == "PianoKeyEb4")
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteGb4" && gameObject.name == "PianoKeyGb4")
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteAb4" && gameObject.name == "PianoKeyAb4")
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteBb4" && gameObject.name == "PianoKeyBb4")
            {
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteDb5" && gameObject.name == "PianoKeyDb5")
            {
                if (Input.GetKeyDown(KeyCode.I))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteEb5" && gameObject.name == "PianoKeyEb5")
            {
                if (Input.GetKeyDown(KeyCode.O))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteGb5" && gameObject.name == "PianoKeyGb5")
            {
                if (Input.GetKeyDown(KeyCode.LeftBracket))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (collision.gameObject.name == "NoteAb5" && gameObject.name == "PianoKeyAb5")
            {
                if (Input.GetKeyDown(KeyCode.RightBracket))
                {
                    //  increment score
                    gm.IncrementScore();
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }

            Destroy(collision.gameObject);
        }
    }

}
