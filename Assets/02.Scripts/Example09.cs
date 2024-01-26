using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example09 : MonoBehaviour
{
    void Start()
    {
        // 1. 숫자형
        // 1-2. 실수형: 소수점이 있는 숫자
        // float, double, decimal

        float floatValue = 3.141592653589793238462643383279f;     // 7자리 정밀도
        double doubleValue = 3.141592653589793238462643383279;    // 15자리 정밀도
        decimal decimalValue = 3.141592653589793238462643383279m; // 29자리 정밀도

        Debug.Log(floatValue);
        Debug.Log(doubleValue);
        Debug.Log(decimalValue);
    }

    void Update()
    {
        
    }
}
