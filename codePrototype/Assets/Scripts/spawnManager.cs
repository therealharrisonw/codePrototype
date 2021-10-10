using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] SpawnPoints; //sets up the array for my randomized spawn cubes. 
   
    
    public GameObject randprefabs;// sets up 
    // create array of materials for "recipe"
    public Material[] materialArray; //arary for my random colors to be checked against player input.
    

    
    // Start is called before the first frame update
    void Start()
    {

        randSpawn(); //calls the custome method i created for spawning my random cubes

    }

    // Update is called once per frame

    public void randSpawn()
    {    
        SpawnPoints = GameObject.FindGameObjectsWithTag("randomSpawn"); //tells the game to populate hte spawpoints array with any object that has the tag randomSpawn

        for (int i = 0; i < SpawnPoints.Length; i++)//sets up a for loop to spawn in the random objects
        {
             GameObject spawnObj = Instantiate(randprefabs, SpawnPoints[i].transform, false); //instantiates my random cube spawner
            materialArray[i] = spawnObj.GetComponent<Renderer>().material; //sets up my materialArray to pull the material information from the objects
        }
    }
   
}
