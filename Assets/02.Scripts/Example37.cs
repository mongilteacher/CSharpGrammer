using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example37 : MonoBehaviour
{
    int Add(int num1, int num2)
    {
        Debug.Log("정수형 더하기");
        return num1 + num2;
    }
    int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    float Add(float num1, float num2)
    {
        Debug.Log("실수형 더하기");
        return num1 + num2;
    }
    // 함수(메소드) 오버로딩: 같은 함수 이름으로 여러 종류의 함수를 구현하는 것
    // - C# 해석기는 자동으로 매개변수의 개수와 데이터 타입을 분석해서 함수를 선택 후 호출
    // (반환 타입만 다르게 하는것은 X)

    void Start()
    {
        Debug.Log(Add(3, 4));
        Debug.Log(Add(3f, 4f));
        Debug.Log(Add(1, 2, 3));
    }
}
