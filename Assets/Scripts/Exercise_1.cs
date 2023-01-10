using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    // Real values

    public int num1;
    public int num2;
    public int num3;
    private int solution;

    private int realValues(int num1, int num2, int num3)
    {
        solution = (num1 + num2 + num3) / 3;
        return solution;
        
    }   

    private void Start()
    {
        realValues(num1, num2, num3);
        Debug.Log($"{solution}");
    }
}
