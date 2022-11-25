using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{

    public int Num;

    // Start is called before the first frame update
    void Start()
    {
        multiplication(Num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void multiplication(int Num)
    {
        Debug.Log($"{Num} x 1 = {Num * 1}");
        Debug.Log($"{Num} x 2 = {Num * 2}");
        Debug.Log($"{Num} x 3 = {Num * 3}");
        Debug.Log($"{Num} x 4 = {Num * 4}");
        Debug.Log($"{Num} x 5 = {Num * 5}");
        Debug.Log($"{Num} x 6 = {Num * 6}");
        Debug.Log($"{Num} x 7 = {Num * 7}");
        Debug.Log($"{Num} x 8 = {Num * 8}");
        Debug.Log($"{Num} x 9 = {Num * 9}");
        Debug.Log($"{Num} x 10 = {Num * 10}");
    }
}
