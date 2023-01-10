using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    public string letter;
    private bool isVowel(string letter)
    {
        if(letter == "a"|| letter == "b")
        {
            return true;
        }
        return false;
    }

    private void Update()
    {
        isVowel(letter);
    }
}
