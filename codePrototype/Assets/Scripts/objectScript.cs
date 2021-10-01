using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectScript : MonoBehaviour
{
    Renderer objRenderer;

    public float timer = 60f;// acts as the timer 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0f)// if timer is greater than 0, print text to console displaying time. 
        {
            timer -= Time.deltaTime;
           print("Time:" + timer);
        }
    }

}
