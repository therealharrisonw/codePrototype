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
       SpawnPoints = GameObject.FindGameObjectsWithTag("randomSpawn");
     

       
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            GameObject spawnObj = Instantiate(randprefabs, SpawnPoints[i].transform, false);
            materialArray[i] =  spawnObj.GetComponent<Renderer>().material;
        }
        // recommend using a for loop
        //foreach (GameObject spawn in randomSpawnPoints)
        //{
            
            // make sure array name is the same as you will setup at the top
            //materialArray[i] = spawnObj.GetComponent<Renderer>().material;
            //for (int i = 0; i >= 4; i = i++  )
            //{
               // materialArray[i] = spawnObj.GetComponent<Renderer>().material;
                
           // }
           // print(materialArray);
       // }

        
        
         


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
