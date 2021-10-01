using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    GameObject[] spawnPoints;
    [SerializeField]
    GameObject prefabs;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoints");
        
        foreach (GameObject spawn in spawnPoints)
        {
            GameObject spawnObj = Instantiate(prefabs, spawn.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
