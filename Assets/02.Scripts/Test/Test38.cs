using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test38 : MonoBehaviour
{
    public string InputString;
    void Start()
    {
        for (char i = 'a'; i <= 'z'; i++)
        {
            int result = InputString.IndexOf(i);
            Debug.Log(result);
        }
    }
}
