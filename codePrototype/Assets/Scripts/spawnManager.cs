using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    GameObject[] randomSpawnPoints; //sets up the array for my randomized spawn cubes. 
   
    [SerializeField]
    GameObject randprefabs;
    // create array of materials for "recipe"
    Material[] materialArray;

    
    // Start is called before the first frame update
    void Start()
    {
       randomSpawnPoints = GameObject.FindGameObjectsWithTag("randomSpawn");
     

       
        // recommend using a for loop
        foreach (GameObject spawn in randomSpawnPoints)
        {
            GameObject spawnObj = Instantiate(randprefabs, spawn.transform, false);
            // make sure array name is the same as you will setup at the top
            //materialArray[i] = spawnObj.GetComponent<Renderer>().material;
            for (int i = 0; i >= 4; i = i++  )
            {
                materialArray[i] = spawnObj.GetComponent<Renderer>().material;
                
            }
            print(materialArray);
        }

        
        
         


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
