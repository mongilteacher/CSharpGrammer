using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example19 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("안녕하세요. 제 이름은 티모입니다.");
       
        // 3. 반복문
        // 반복문은 설정한 조건이 참(true)일 동안 코드 블록 내부 ("{}") 를 반복해서 실행하는 것
        // for, while


        // 3-1. for
        /**
         for 반복문은 괄호 내부에
         for(괄호 내부)
            - 초기식;
            - 조건식;
            - 증감식

        for(초기식; 조건식; 증감식)
        {
             // 반복할 코드들...
        }
        // 초기식: 초기화
        // 조건식: 비교 연산자
        // 증감식: 산술연산, ++, --
        **/ 
         
        for(int i = 0; i < 1000; i++)
        {
            Debug.Log("안녕하세요. 제 이름은 티모입니다.");
        }
    }
}
