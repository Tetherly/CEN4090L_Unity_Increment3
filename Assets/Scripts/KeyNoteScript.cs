using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyNoteScript : MonoBehaviour
{
    
    public AudioSource C4;
    public AudioSource D4;
    public AudioSource E4;
    public AudioSource F4;
    public AudioSource G4;
    public AudioSource A4;
    public AudioSource B4;
    public AudioSource C5;
    public AudioSource D5;
    public AudioSource E5;
    public AudioSource F5;
    public AudioSource G5;
    public AudioSource A5;
    public AudioSource Db4;
    public AudioSource Eb4;
    public AudioSource Gb4;
    public AudioSource Ab4;
    public AudioSource Bb4;
    public AudioSource Db5;
    public AudioSource Eb5;
    public AudioSource Gb5;
    public AudioSource Ab5;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.CapsLock))
            C4.Play();
        if (Input.GetKeyDown(KeyCode.A))
            D4.Play();
        if (Input.GetKeyDown(KeyCode.S))
            E4.Play();
        if (Input.GetKeyDown(KeyCode.D))
            F4.Play();
        if (Input.GetKeyDown(KeyCode.F))
            G4.Play();
        if (Input.GetKeyDown(KeyCode.G))
            A4.Play();
        if (Input.GetKeyDown(KeyCode.H))
            B4.Play();
        if (Input.GetKeyDown(KeyCode.J))
            C5.Play();
        if (Input.GetKeyDown(KeyCode.K))
            D5.Play();
        if (Input.GetKeyDown(KeyCode.L))
            E5.Play();
        if (Input.GetKeyDown(KeyCode.Semicolon))
            F5.Play();
        if (Input.GetKeyDown(KeyCode.Quote))
            G5.Play();
        if (Input.GetKeyDown(KeyCode.Return))
            A5.Play();
        if (Input.GetKeyDown(KeyCode.Q))
            Db4.Play();
        if (Input.GetKeyDown(KeyCode.W))
            Eb4.Play();
        if (Input.GetKeyDown(KeyCode.R))
            Gb4.Play();
        if (Input.GetKeyDown(KeyCode.T))
            Ab4.Play();
        if (Input.GetKeyDown(KeyCode.Y))
            Bb4.Play();
        if (Input.GetKeyDown(KeyCode.I))
            Db5.Play();
        if (Input.GetKeyDown(KeyCode.O))
            Eb5.Play();
        if (Input.GetKeyDown(KeyCode.LeftBracket))
            Gb5.Play();
        if (Input.GetKeyDown(KeyCode.RightBracket))
            Ab5.Play();
    }
}