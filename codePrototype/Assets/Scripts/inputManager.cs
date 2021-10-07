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
        gs = GameObject.Find("GuessManager").GetComponent<guessLogic>();
        ts = GameObject.Find("Main Camera").GetComponent<timerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        
        gameObject.GetComponent<Renderer>();
        gs.guesses[gs.count] = gameObject.GetComponent<Renderer>().material;
        gs.count++;
    }
}
