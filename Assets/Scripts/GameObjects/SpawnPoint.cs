using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private SpawnManager spawnManager;
    private CircleCollider2D spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        spawnPoint = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        spawnManager.SetSpawnPoint(spawnPoint.bounds.center);
        PlayerPrefs.SetString("spawnPoint", this.name);
    }
}
