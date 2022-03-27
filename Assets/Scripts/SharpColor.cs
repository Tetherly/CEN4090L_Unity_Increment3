using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UI
{
    public class SharpOutline : MonoBehaviour
    {
        public GameObject key;
        TextMesh tm;
        public KeyCode changeColor;

        // Start is called before the first frame update
        void Start()
        {
            tm = GetComponent<TextMesh>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(changeColor))
                tm.color = Color.blue;
            else
                tm.color = Color.white;
        }
    }
}

