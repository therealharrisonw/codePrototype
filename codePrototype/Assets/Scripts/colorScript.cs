using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorScript : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        int rand = Random.Range(0, materials.Length);
        rend.material = materials[rand];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
