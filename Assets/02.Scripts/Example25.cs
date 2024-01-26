using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example25 : MonoBehaviour
{
    public int[] N;


    private void Start()
    {
        // Length 속성: 배열의 길이
        Debug.Log(N.Length);

        int count = N.Length;
        for(int i = 0; i < count; i++)
        {
            Debug.Log(N[i]);
        }
    }
}
