using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    // GAME OVER

    public int counter;

    private void Counter()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            counter++;
        }
        else if(counter== 10)
        {
            Debug.Log($"GAME OVER");
        }
    }

    private void Update()
    {
        Counter();
    }
    

}
