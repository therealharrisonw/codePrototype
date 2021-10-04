using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    GameObject[] randomSpawnPoints; //sets up the array for my randomized spawn cubes. 
    [SerializeField]
    GameObject randprefabs;
    // Start is called before the first frame update
    void Start()
    {
       randomSpawnPoints = GameObject.FindGameObjectsWithTag("randomSpawn");
        
        
        foreach (GameObject spawn in randomSpawnPoints)
        {
            GameObject spawnObj = Instantiate(randprefabs, spawn.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
