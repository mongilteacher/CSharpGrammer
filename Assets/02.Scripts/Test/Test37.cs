using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test37 : MonoBehaviour
{
    public string InputString = "Hello C#";
    void Start()
    {
        string answer = "";
        for (int i = InputString.Length-1; i >=0; i--)
        {
            answer += InputString[i];
        }
        Debug.Log(answer);
    }
}
