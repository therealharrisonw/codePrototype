using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessLogic : MonoBehaviour
{
    spawnManager sm; //used to help draw in information from my spawnManager script
    public Material[] guesses; //the array used to hold guesses from the player input
    public int count = 0; //used to increment count and to set up for checking later
     int score = 0; //the score variable 


    // Start is called before the first frame update
    void Start()
    {

        sm = GameObject.Find("spawnManager").GetComponent<spawnManager>();//links my random array in spawnManager into this script for ease of refrencing it later

    }

    public void recipeChecker() //method for checking answers against guesses. 
    {
        if (count == guesses.Length) //checks that count equals the length of my guesses array
        {
            
            for(int i = 0; i < guesses.Length; i++) //sets up the ability to check the arrays against each other in one loop
            {
                
                if (guesses[i].name == sm.materialArray[i].name) //checks the guess and answer array against each other in each slot
                {
                    

                    if(guesses[3].name == sm.materialArray[3].name) //tells the for loop to check the last spot on each array before running this. 
                    { 
                        score++; //increments the score variable by one 
                        print("score" + score); //let's player know that the score increased. may be lost in the console due to timer.
                        break; //tells the for loop to end and move onto the next thing
  
                    }
                    
                }
                else
                {
                    print("incorect"); //lets player know that they were incorrect. Might be lost due to the timer. 
                    break; //tells the for loop to end and move on to the next thing. 
                    
                }
               
            } Round2();// calls the round two method to set up a new round

             void Round2() //used for setting up the next round of gameplay. 
            {
                print("Your current score is" + score);
                Destroy(sm.materialArray[0]); //unfortunatelty this is the hardcoded way to clear out the recipe. But i could not get a soft coded way to work.
                Destroy(sm.materialArray[1]);
                Destroy(sm.materialArray[2]);
                Destroy(sm.materialArray[3]);
                sm.randSpawn();// my method for spawning in cubes 

                count = 0; //resests the guess counter for the new round
                for (int a = 0; a < guesses.Length; a++)
                {
                    guesses[a] = null;//clears out the guesses array for the new round
                    
                    
                       
                        
                    
                   
                    
                }
            }   

        }
    }
}


