using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{

    public float Num1 = 7f;

    // Start is called before the first frame update
    void Start()
    {
        absoluteValue(Num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool absoluteValue(float Num1)
    {
        if(Num1 < 0 || Num1 == 0)
        {
            Debug.Log($"The absolute value of {Num1} is {Num1 * (-1)}");
            return true;
        }

        Debug.Log($"The absolute value of {Num1} is {Num1 * 1}");
        return false;
    }
}
