using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    // Number array - more of 5 elements

    public int[] numbers;

    private void Start()
    {
        if(numbers.Length <= 5)
        {
            Debug.Log($"First element = 10");
            Debug.Log($"Third element = -100");
            Debug.Log($"Fifth element = 7");
        }
        else
        {
            Debug.Log($"Missing elements");
        }
    }
}
