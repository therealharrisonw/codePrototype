using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    GameObject[] SpawnPoints; //sets up the array for my randomized spawn cubes. 
   
    [SerializeField]
    GameObject randprefabs;// sets up 
    // create array of materials for "recipe"
    public Material[] materialArray; //arary for my random colors to be checked against player input.

    
    // Start is called before the first frame update
    void Start()
    {
        randSpawn();
   

        
        
         


    }

    // Update is called once per frame

    public void randSpawn()
    {
        SpawnPoints = GameObject.FindGameObjectsWithTag("randomSpawn");



        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            GameObject spawnObj = Instantiate(randprefabs, SpawnPoints[i].transform, false);
            materialArray[i] = spawnObj.GetComponent<Renderer>().material;
        }
    }
    void Update()
    {
        
    }
}
