using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_0109 : MonoBehaviour
{
    // Q1. 정수 2개를 매개변수로 넘겨받아 두 수중 더 큰 수를 반환하는 함수를 만들고 테스트
    int Max(int num1, int num2)
    {
        if(num1 > num2)
        {
            return num1;
        }
        return num2;
    }

    // Q2. 정수 3개를 매개변수로 넘겨받아 평균을 구해 반환하는 함수를 만들고 테스트 (평균은 소수점이 있음)
    float Average(int num1, int num2, int num3)
    {
        int sum = num1 + num2 + num3;
        return sum / 3f;
    }
    // Q3. 정수 1개를 매개변수로 넘겨 받아 0부터 해당 정수값까지 출력해 주는 함수를 만들고 테스트 (반환안함)
    void LogNums(int num)
    {
        for(int i = 0; i <= num; ++i)
        {
            Debug.Log(i);
        }
    }



    void Start()
    {
        // 호출: 함수이름(매개변수);
        Debug.Log(4);
        int result = Max(2, 4);

        LogNums(2);


        Debug.Log(Mathf.Max(6, 4));
    }
}
