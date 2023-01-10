using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Login: user and password

    public string username;
    public string password;

    private bool Login(string username, string password)
    {
        if(username == "admin" && password == "abccba")
        {
            return true;
        }
        return false;

        //Debug.Log($"{Login}");
    }

    private void Start()
    {
        Login(username, password);
    }
}
