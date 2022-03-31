using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    Demo d1;

    public AudioSource MissedNote;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "notes")
        {
            if(gameObject.name == "NoteC4")
            {
                if (Input.GetKeyDown(KeyCode.CapsLock))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }else if(gameObject.name == "NoteD4")
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteE4")
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteF4")
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteG4")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteA4")
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteB4")
            {
                if (Input.GetKeyDown(KeyCode.H))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteC5")
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteD5")
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteE5")
            {
                if (Input.GetKeyDown(KeyCode.L))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteF5")
            {
                if (Input.GetKeyDown(KeyCode.Semicolon))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteG5")
            {
                if (Input.GetKeyDown(KeyCode.Quote))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteA5")
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteDb4")
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteEb4")
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteGb4")
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteAb4")
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteBb4")
            {
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteDb5")
            {
                if (Input.GetKeyDown(KeyCode.I))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteEb5")
            {
                if (Input.GetKeyDown(KeyCode.O))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteGb5")
            {
                if (Input.GetKeyDown(KeyCode.LeftBracket))
                {
                    //  increment score
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }
            else if (gameObject.name == "NoteAb5")
            {
                if (Input.GetKeyDown(KeyCode.RightBracket))
                {
                    //  increment score
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
