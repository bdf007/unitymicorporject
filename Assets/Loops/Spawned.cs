using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawned : MonoBehaviour
{
    public GameObject spawnPrefab;
    public int spanwCount = 5;
    public float spanwOffset = 1.5f;

    void Start ()
    {
        if(spawnPrefab != null) 
        {
            SpawnEnemies();
        }
        else 
        {
            Debug.LogError("Cannot spawn enemies! Prefab is missing!");
        }
    }

    void SpawnEnemies () 
    {
        for(int i = 0; i< spanwCount; i++)
        {
            float xPos = i * spanwOffset;
            // definition de la nouvelle position
            Vector3 spawnPos = new Vector3(xPos, 0, 0); 
            // quaternion.identity signifie que l'objet n'a pas de rotation
            Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
        }
    }
}
