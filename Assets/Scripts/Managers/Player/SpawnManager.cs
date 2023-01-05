using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPoint = new Vector3();
    public Transform startingSpawn;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = startingSpawn.position;
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpawnPoint(Vector3 position)
    {
        spawnPoint = position;
        // Debug.Log("New spawn point set: " + position);
    }

    public void Respawn()
    {
        gameObject.transform.position = spawnPoint;
    }
}
