using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpKeyManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "notes")
        {
            Destroy(collision.gameObject);    
        }
          
     }
}
