using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessLogic : MonoBehaviour
{
    spawnManager sm;
    public GameObject[] interactables;
    public Material[] guesses;
    public int count = 0; //used to 
    //int score = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("spawnManager").GetComponent<spawnManager>();//links my random array in spawnManager into this script for ease of refrencing it later
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recipeChecker()
    {
        if (count == guesses.Length - 1)
        {
            for (int i = 0; i >= 4; i++)
            {
                //if (guesses[i] == materialArray[i])
                //{
                    //score++;
                    //print("score" + score);
                    //reset the random pattern,count integer, guesses array
               // }
                //else
                //{
                    //print("incorect");
                    //either break or repeat;
                    //reset the random pattern;count integer, guesses array
                //}
            }
            }
        }
    }
}
