using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public int Num;

    // Start is called before the first frame update
    void Start()
    {
        Calculate(Num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool Calculate(int Even)
    {
        if (Even % 2 == 0)
        {
            Debug.Log($"{Num} is even.");
            return true;
        }
        Debug.Log($"{Num} isn't even.");
            return false;
    }
}
