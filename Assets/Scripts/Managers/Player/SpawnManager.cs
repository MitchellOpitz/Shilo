using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPoint = new Vector3();
    public string deathSound;

    // Start is called before the first frame update
    void Start()
    {

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
        FindObjectOfType<AudioManager>().PlaySound(deathSound);
        gameObject.transform.position = spawnPoint;
    }
}
