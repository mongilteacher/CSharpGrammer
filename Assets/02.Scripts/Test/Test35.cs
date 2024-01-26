using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test35 : MonoBehaviour
{

    void Start()
    {
        string[] inputStrings = new string[] { "전민성", "김예은", "이성민" };

        foreach(string name in inputStrings)
        {
            Debug.Log($"{name[0]}{name[name.Length - 1]}");
        }

    }
}
