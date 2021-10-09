using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    guessLogic gs;
    timerScript ts;
    
    // Start is called before the first frame update
    void Start()
    {
        gs = GameObject.Find("guessManager").GetComponent<guessLogic>(); //pulling my script over to set up my guessLogic, guesses and count
        ts = GameObject.Find("Main Camera").GetComponent<timerScript>(); //
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        while (ts.clicker)
        {


            gs.guesses[gs.count] = gameObject.GetComponent<Renderer>().material;
            gs.count++;
            gs.recipeChecker();
        }
        
    }
}
