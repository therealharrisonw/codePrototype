using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    GameObject[] randomSpawnPoints; //sets up the array for my randomized spawn cubes. 
    GameObject spawn1;
    GameObject spawn2;
    GameObject spawn3;
    GameObject spawn4;
    GameObject spawn5;
    GameObject spawn6;
    GameObject spawn7;
    GameObject spawn8;
    [SerializeField]
    GameObject randprefabs;
    // create array of materials for "recipe"
    Material[] materialArray;

    public GameObject spawncolor1;
    public GameObject spawncolor2;
    public GameObject spawncolor3;
    public GameObject spawncolor4;
    public GameObject spawncolor5;
    public GameObject spawncolor6;
    public GameObject spawncolor7;
    public GameObject spawncolor8;
    // Start is called before the first frame update
    void Start()
    {
       randomSpawnPoints = GameObject.FindGameObjectsWithTag("randomSpawn");
        spawn1 = GameObject.FindGameObjectWithTag("spawn1");
        spawn2 = GameObject.FindGameObjectWithTag("spawn2");
        spawn3 = GameObject.FindGameObjectWithTag("spawn3");
        spawn4 = GameObject.FindGameObjectWithTag("spawn4");
        spawn5 = GameObject.FindGameObjectWithTag("spawn5");
        spawn6 = GameObject.FindGameObjectWithTag("spawn6");
        spawn7 = GameObject.FindGameObjectWithTag("spawn7");
        spawn8 = GameObject.FindGameObjectWithTag("spawn8");

            GameObject spawnObj1 = Instantiate(spawncolor1, spawn1.transform, false);
            GameObject spawnObj2 = Instantiate(spawncolor2, spawn2.transform, false);
            GameObject spawnObj3 = Instantiate(spawncolor3, spawn3.transform, false);
            GameObject spawnObj4 = Instantiate(spawncolor4, spawn4.transform, false);
            GameObject spawnObj5 = Instantiate(spawncolor5, spawn5.transform, false);
            GameObject spawnObj6 = Instantiate(spawncolor6, spawn6.transform, false);
            GameObject spawnObj7 = Instantiate(spawncolor7, spawn7.transform, false);
            GameObject spawnObj8 = Instantiate(spawncolor8, spawn8.transform, false);
        // recommend using a for loop
        foreach (GameObject spawn in randomSpawnPoints)
        {
            GameObject spawnObj = Instantiate(randprefabs, spawn.transform, false);
            // make sure array name is the same as you will setup at the top
            //materialArray[i] = spawnObj.GetComponent<Renderer>().material;
            for (int i = 0; i >= 4; i = i++  )
            {
                materialArray[i] = spawnObj.GetComponent<Renderer>().material;
                print(materialArray);
            }
        }

        
        
         


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
