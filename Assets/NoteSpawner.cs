using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] spawnPoints;
    public GameObject[] notePrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randomNote = Random.Range(0, notePrefabs.Length);
            int randNoteSpawn = Random.Range(0, spawnPoints.Length);

            Instantiate(notePrefabs[0], spawnPoints[randNoteSpawn].position, transform.rotation);
        }
    }
}
