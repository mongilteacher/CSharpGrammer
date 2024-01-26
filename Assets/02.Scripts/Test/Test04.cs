using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public int A = 472;
    public int B = 385;


    void Start()
    {
        // (3)
        // A * (B의 1의 자리)
        int num3 = A * (B % 10);
        Debug.Log(num3);

        // (4)
        // A * (B의 10 자리)
        int num4 = A * (B / 10 % 10);

        // (5)
        // A * (B의 100 자리)
        int num5 = A * (B / 100);

        // 6.
        Debug.Log(A * B);
    }

   
}
