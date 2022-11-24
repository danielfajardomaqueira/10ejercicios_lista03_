using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{

    public string letter;
    

    // Start is called before the first frame update
    void Start()
    {
        VowelDetecter(letter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool VowelDetecter(string l)
    {
        if (l == "a" || l == "e" || l == "i" || l == "o" || l == "u")
        {
            Debug.Log($"{letter} is a Vowel");
            return true;
            
        }

        Debug.Log($"{letter} isn't a Vowel");
        return false;
        
    }
}
