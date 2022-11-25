using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{

    public int NumYear;
    
    

    // Start is called before the first frame update
    void Start()
    {
        leapYear(NumYear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool leapYear(int NumYear)
    {
        if (NumYear % 400 == 0)
        {
            Debug.Log($"{NumYear} is a leap year");
            return true;
        }
        Debug.Log($"no");
        return false;
        
        
        
    }

}
