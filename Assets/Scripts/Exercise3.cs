using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public int NumDividend;
    public int NumDivisor;
    

    // Start is called before the first frame update
    void Start()
    {
        Division(NumDividend, NumDivisor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Division(int NumDividend, int NumDivisor)
    {
        
        if (NumDividend % NumDivisor == 0)
        {
            Debug.Log($"The division of dividend {NumDividend} by divisor {NumDivisor} is exact");

        }
            Debug.Log($"The division of dividend {NumDividend} by divisor {NumDivisor} isn't exact");
            
        
        
        
    }

}
