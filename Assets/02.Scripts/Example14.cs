using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example14 : MonoBehaviour
{
    void Start()
    {
        // 5. 논리 연산자
        // 조건을 비교하는 비교 연산자가 동시에 두 개 이상 사용할때 사용한다.
        // 결과는 true, false

        // && (AND): 그리고, 두 조건이 모두 참일때만 참
        // || (OR):    또는, 두 조건 중 하나만 참이어도 참
        // !  (NOT): 참은 거짓으로, 거짓은 참으로 바꿔주는 연산자

        int num1 = 40;
        int num2 = 30;
        int num3 = 20;

        // AND
        bool result1 = num1 > num2 && num2 > num3;
        //                 true    &&    true        -> result1: true 

        int hour = 14;
        // 00분식점은 오픈 시간 10시부터 20시까지입니다.
        bool isOpen = (10 <= hour) && (hour <= 20);

        // OR
        bool result2 = num1 > num2 || num2 < num3;
        //                 true    ||    false       -> result2: true
        // 00분식점은 할인 시간 15시 또는 19시입니다.
        bool isDiscardTime = (hour == 15) || (hour == 19); 

        // NOT
        bool result3 = !true;   // false


        int a = 10;
        int b = 20;


        // 연산자 우선순위
        // 연산자마다 우선순위가 정해져 있다.
        // 괄호 안에 있는 연산자가 가장 먼저 계산되므로 헷갈리면 괄호로 구분하자.
        bool example = (((a++) * 5) + 2) > (++b +1 * 3 / 2); 
    }

   
}
