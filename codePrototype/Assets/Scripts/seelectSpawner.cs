using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seelectSpawner : MonoBehaviour
{
    public GameObject selectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(selectPrefab, transform);
    }

    // Update is called once per frame
}
