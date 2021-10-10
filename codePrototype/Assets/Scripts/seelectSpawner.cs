using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seelectSpawner : MonoBehaviour
{
    public GameObject selectPrefab; //allows me to select which prefab cube to spawn
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(selectPrefab, transform); //spawns the prefab cube in a spot
    }

    // Update is called once per frame
}
