using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerScript : MonoBehaviour
{
    public float timer = 60f;// acts as the timer 
    public bool runTime = false; // is used for deciding the bool for void 
    public bool clicker = true; // used for turning on and off the ability to click 
    guessLogic gl;
    // Start is called before the first frame update
    void Start()
    {
        runTime = true; //sets runTime to true so that the timer runs.
        gl = GameObject.Find("guessManager").GetComponent<guessLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (runTime == true) //as long as runTime is true it will check my time
        {
            if (timer > 0f)// if timer is greater than 0, print text to console displaying time. 
            {
                timer -= Time.deltaTime; //tells timer to subtract its predetermined time by deltaTime.
                print("Time:" + timer); //prints the time to the console.
            }
            else
            {
                print("Time's Up!" ); //tells the player they are out of time
                clicker = false; //turns off the ability to click
            }
        }
    }
}
