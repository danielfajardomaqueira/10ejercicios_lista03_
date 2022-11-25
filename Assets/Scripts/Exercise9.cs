using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise9 : MonoBehaviour
{

    public float Base;
    public float Height;


    // Start is called before the first frame update
    void Start()
    {
        areaTriangle(Base, Height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void areaTriangle(float Base, float Height)
    {
        if(Base > 0 && Height > 0)
        {
            Debug.Log($"The area of the triangle is {(Base * Height) / 2}");
        }
        else
        {
            Debug.Log($"The area cannot be calculated");
        }
    }
}
