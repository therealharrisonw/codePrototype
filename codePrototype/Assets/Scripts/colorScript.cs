using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorScript : MonoBehaviour
{
    public Material[] materials; //sets up a public array for materials to be loaded in
    Renderer rend; //sets up a renderer for pulling information for random cube
    
    // Start is called before the first frame update
    void Awake() //has to go before start to work
    {
        rend = GetComponent<Renderer>(); //tells rend to get the renderer component. 
        int rand = Random.Range(0, materials.Length); //sets up a random color generator 
        rend.material = materials[rand]; //tells the material to be randomized using the array
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
