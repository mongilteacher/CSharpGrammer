using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example12 : MonoBehaviour
{
    // 연산(계산)이란 계산을 통해 새로운 값을 만드는 것
    // "연산자"는 연산을 수행할때 쓰는 기호
    void Start()
    {
        // 1. 사칙연산자
        // +, -, /(몫), *(곱하기), %(나머지)
        int a = 5;
        int b = 3;

        Debug.Log($"{a}+{b}={a+b}");
        Debug.Log($"{a}-{b}={a+b}");
        Debug.Log($"{a}/{b}={a+b}");
        Debug.Log($"{a}*{b}={a+b}");
        Debug.Log($"{a}%{b}={a+b}");

        // 2. 대입 연산자
        // (계산한)값을 변수에 대입(할당)하는 연산자
        // 기본 대입 연산자
        int c = 3;

        // OO 대입 연산자
        c = c + 5;

        c += 5;
        Debug.Log($"c+=5: {c}");

        c -= 3;
        Debug.Log(c);

        c *= 3;
        c /= 7;

        // 3. 증감(증가/감소) 연산자
        // ex) 1을 더할때...
        c = c + 1; // 덧셈 연산자
        c += 1;    // 덧셈 대입 연산자
        c++;       // 1 증가 연산자
        c--;       // 1 감소 연산자 

        ++c;

        int number = 10;
        Debug.Log(number);   // 10

        Debug.Log(number++); // 10   // 후위 증가: 다른 연산을 먼저 수행 후, 값 1 증가
        Debug.Log(number);   // 11

        Debug.Log(++number); // 12 // 전위 증가: 값 1 증가 후 다른 연산 수행
        Debug.Log(number);   // 12
    }
}
