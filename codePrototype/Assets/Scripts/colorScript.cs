using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorScript : MonoBehaviour
{
    public Material[] materials;
    //public Material[] slectmat;
    Renderer rend;
    Renderer selectrend;
    int selectcolor;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        int rand = Random.Range(0, materials.Length);
        rend.material = materials[rand];
        //slectmat = GameObject.FindGameObjectsWithTag("selectCubes");

        selectrend = GetComponent<Renderer>();
        
        //selectrend = GameObject.FindGameObjectsWithTag("selectCubes");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
