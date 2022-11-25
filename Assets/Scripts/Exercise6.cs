using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{

    public float Num1 = 40.5f;
    public float Num2 = 60.2f;

    // Start is called before the first frame update
    void Start()
    {
        largerNumber(Num1, Num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool largerNumber(float Num1, float Num2)
    {
        if(Num1 < Num2)
        {
            Debug.Log($"The Number {Num2} is larger");
            return true;
        }

        Debug.Log($"The Number {Num1} is larger");
        return false;
    }
}
