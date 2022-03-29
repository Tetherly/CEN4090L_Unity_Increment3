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
            if(gameObject.name == "KeyC4")
            {
                if (Input.GetKeyDown(KeyCode.CapsLock))
                {
                    
                }
                else
                {
                    // Play Missed Note Sound
                    MissedNote.Play();
                }
            }else if(gameObject.name == "KeyD4")
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
            else if (gameObject.name == "KeyE4")
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
            else if (gameObject.name == "KeyF4")
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
            else if (gameObject.name == "KeyG4")
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
            else if (gameObject.name == "KeyA4")
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
            else if (gameObject.name == "KeyB4")
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
            else if (gameObject.name == "KeyC5")
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
            else if (gameObject.name == "KeyD5")
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
            else if (gameObject.name == "KeyE5")
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
            else if (gameObject.name == "KeyF5")
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
            else if (gameObject.name == "KeyG5")
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
            else if (gameObject.name == "KeyA5")
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
            else if (gameObject.name == "KeyDb4")
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
            else if (gameObject.name == "KeyEb4")
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
            else if (gameObject.name == "KeyGb4")
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
            else if (gameObject.name == "KeyAb4")
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
            else if (gameObject.name == "KeyBb4")
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
            else if (gameObject.name == "KeyDb5")
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
            else if (gameObject.name == "KeyEb5")
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
            else if (gameObject.name == "KeyGb5")
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
            else if (gameObject.name == "KeyAb5")
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
