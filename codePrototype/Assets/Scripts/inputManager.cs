using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    guessLogic gs; //used for ease of getting guessLogic informatin from that script into this one
    timerScript ts; //used for getting timeScript information from that script into this one 
    
    // Start is called before the first frame update
    void Start()
    {
        gs = GameObject.Find("guessManager").GetComponent<guessLogic>(); //pulling my script over to set up my guessLogic, guesses and count
        ts = GameObject.Find("Main Camera").GetComponent<timerScript>(); //pulling the timeScript over for use of acess when setting up the clicker
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown() //used when the player clicks the mouse down. 
    {
        
        


            gs.guesses[gs.count] = gameObject.GetComponent<Renderer>().material; //tells the game that when the player clicks on an object to fill it into the guesses array in the count spot and to get the material
            gs.count++; //increments the count variable which makes it so guesses doesn't get over written
            gs.recipeChecker(); //this calls the custom method to check answers against guesses
        
        
    }
}
