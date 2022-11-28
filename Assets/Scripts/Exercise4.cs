using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{

    private Vector3 initialPos = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        Movement(initialPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Movement(Vector3 direction)
    {
        transform.Translate(direction);
    }
}
