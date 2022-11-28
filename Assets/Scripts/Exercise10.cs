using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10 : MonoBehaviour
{

    private int ScaleValor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncrementScale();
        }
    }

    private void IncrementScale()
    {
        
        
            transform.localScale += Vector3.one;
        
    }
}
