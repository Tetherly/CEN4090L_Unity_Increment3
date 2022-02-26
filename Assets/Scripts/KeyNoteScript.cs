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
    public AudioSource B5;
    public AudioSource C4sharp;
    public AudioSource D4sharp;
    public AudioSource F4sharp;
    public AudioSource G4sharp;
    public AudioSource A4sharp;
    public AudioSource C5sharp;
    public AudioSource D5sharp;
    public AudioSource F5sharp;
    public AudioSource G5sharp;
    public AudioSource A5sharp;

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
        if (Input.GetKeyDown(KeyCode.Q))
            C4sharp.Play();
        if (Input.GetKeyDown(KeyCode.W))
            D4sharp.Play();
        if (Input.GetKeyDown(KeyCode.R))
            F4sharp.Play();
        if (Input.GetKeyDown(KeyCode.Q))
            G4sharp.Play();
        if (Input.GetKeyDown(KeyCode.Y))
            A4sharp.Play();
        if (Input.GetKeyDown(KeyCode.I))
            C5sharp.Play();
        if (Input.GetKeyDown(KeyCode.O))
            D5sharp.Play();
        if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            F5sharp.Play();
        if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            G5sharp.Play();
    }

    /*
    public void C4_Stroke()
    {
        C4.Play();
    }

    public void D4_Stroke()
    {
        D4.Play();
    }

    public void E4_Stroke()
    {
        E4.Play();
    }

    public void F4_Stroke()
    {
        F4.Play();
    }

    public void G4_Stroke()
    {
        G4.Play();
    }

    public void A4_Stroke()
    {
        A4.Play();
    }

    public void B4_Stroke()
    {
        B4.Play();
    }

    public void C5_Stroke()
    {
        C5.Play();
    }

    public void D5_Stroke()
    {
        D5.Play();
    }

    public void E5_Stroke()
    {
        E5.Play();
    }

    public void F5_Stroke()
    {
        F5.Play();
    }

    public void G5_Stroke()
    {
        G5.Play();
    }
    
    public void A5_Stroke()
    {
        A5.Play();
    }

    public void B5_Stroke()
    {
        B5.Play();
    }
    */

}