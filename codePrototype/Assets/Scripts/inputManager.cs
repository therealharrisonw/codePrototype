using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    Material[] selectColor;
    GameObject[] selectorCubes;
    // Start is called before the first frame update
    void Start()
    {
        selectorCubes = GameObject.FindGameObjectsWithTag("selectCubes");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        for (int i = 0; i <= 4; i++)
        {
            //selectColor[i] = selectorCubes.GetComponent<Renderer>().material;
        }
        
    }
}
