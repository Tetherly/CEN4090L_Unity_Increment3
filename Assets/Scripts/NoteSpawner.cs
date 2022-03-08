using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private GameObject[] notePrefabs;
    void Start()
    {
        InvokeRepeating("SpawnMusicNotes", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void SpawnMusicNotes()
    {
        int randomNote = Random.Range(0, notePrefabs.Length);
        int randNoteSpawn = Random.Range(0, spawnPoints.Length);

        Instantiate(notePrefabs[0], spawnPoints[randNoteSpawn].position, transform.rotation);
        
    }
}
