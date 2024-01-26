using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35 : MonoBehaviour
{
    /**
       // 반환 자료형이 없을 경우: void
      '반환 자료형' '함수 이름'('매개변수 목록')
       {
            // 실행할 코드들
            // return 반환 데이터
       }
    **/

    int Sum(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    void Start()
    {
        // 더하기
        int num1 = 0;
        int num2 = 0;
        int result = 0;

        num1 = 1;
        num2 = 3;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");

        num1 = 17;
        num2 = 9;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");

        num1 = 22;
        num2 = 33;
        result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");
    }

    void Update()
    {
        
    }
}
