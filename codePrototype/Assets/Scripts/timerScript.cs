using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerScript : MonoBehaviour
{
    public float timer = 60f;// acts as the timer 
    public bool runTime = false; // is used for deciding the bool for void 
    public bool clicker = true; // used for 
    // Start is called before the first frame update
    void Start()
    {
        runTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (runTime == true)
        {
            if (timer > 0f)// if timer is greater than 0, print text to console displaying time. 
            {
                timer -= Time.deltaTime;
                print("Time:" + timer);
            }
            else
            {
                runTime = false;
                print("Time's Up shmuck");
                clicker = false;
            }
        }
    }
}
