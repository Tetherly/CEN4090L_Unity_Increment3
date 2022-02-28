using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeKeyColor : MonoBehaviour
{
    public GameObject key;
    bool toggle = false;
    SpriteRenderer sr;
    public KeyCode changeColor;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(changeColor))
        {
            toggle = !toggle;
            sr.color = toggle ? Color.blue : Color.white;
        }

    }
}

