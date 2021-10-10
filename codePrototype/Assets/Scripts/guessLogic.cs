using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessLogic : MonoBehaviour
{
    spawnManager sm;
    public Material[] guesses;
    public int count = 0; //used to help keep the count 
     int score = 0;


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
        if (count == guesses.Length)
        {
            
            for(int i = 0; i < guesses.Length; i++)
            {
                Debug.Log("For Test");
                if (guesses[i].name == sm.materialArray[i].name)
                {
                    Debug.Log("Analyze");

                    if(guesses[3].name == sm.materialArray[3].name)
                    {
                        Debug.Log("This should print only once");
                        score++;
                        print("score" + score);
                       
                        break;
                       
                        //for (int a = 0; a < guesses.Length; a++)
                        //{
                            //count = 0;
                           // guesses[a] = null;
                        //}
                        
                        
                    }
                    
                }
                else
                {
                    print("incorect");
                    break;
                    //either break or repeat;
                    //reset the random pattern;count integer, guesses array
                }
               
            } Round2();

             void Round2()
            {

                
                

                
                   
                
                for (int a = 0; a < guesses.Length; a++)
                {
                    if(guesses[a].name == sm.materialArray[0].name)
                    {
                        Destroy(sm.materialArray[0]);
                        sm.randSpawn();
                        guesses[a] = null;
                        count = 0;
                    }
                   
                    
                }
            }   

        }
    }
}


