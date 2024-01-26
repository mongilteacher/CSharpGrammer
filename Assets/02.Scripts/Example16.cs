using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 코드는 위에서 아래로 (순차적으로) 실행되는 흐름을 가지고 있다. -> 순차적인 흐름
        Debug.Log(1);
        Debug.Log(2);
        Debug.Log(3);
        // 제어문: 위에서 아래로 실행되는 흐름을 제어
        // 제어문의 종류: 조건문, 분기문, 반복문


        // 1. 조건문(if문)
        // 조건에 따라 맞는 상황을 수행하는데 쓰인다.
        // 설정한 조건식에 따라 "할지 안할지", "무엇을 할지" 정할 수 있다.
        // 조건식: 비교 연산자를 쓰는 식
        //       - 양쪽 값(변수)을 비교해서 결과를 true(참) 또는 false(거짓)인지 판명해주는 연산자
        //       - 비교란: 주어진 값들이 같은지 다른지 큰지 작은지 구분하는 것을 의미


        // if: 만약 ~라면? ~한다.
        // else: 그렇지 않다면 ~한다.

        // if: 만약 ~라면? ~한다.
        // else if: 그렇지 않고 ~라면? ~한다.
        // else: 이도저도 아니라면? ~한다.

        /**
        if(조건식)  만약 ~라면
        {
            ~한다.
            조건식이 참(true)이면 실행할 코드들
        }
        **/

        int health = 100;
        int damage = 200;

        health -= damage;

        if(health <= 0)
        {
            Debug.Log("게임 오버");
        }
        else
        {
            Debug.Log("게임 계속 진행");
        }

        Debug.Log("!");



        int temperature = 0;
        if(temperature <= 12)
        {        
            // 온도가 12도 이하가되면 "한파주의보"라는 텍스트를 출력
            Debug.Log("한파주의보");
        }
        else if(temperature >= 36)
        {
            // 온도가 36도 이상이면 "폭염주의보"라는 텍스트를 출력
            Debug.Log("폭염주의보");
        }
        else
        //if(temperature > 12 && temperature < 36)
        {
            // 온도가 12도 초과 36도 미만이면 "정상 온도"라는 텍스트를 출력
            Debug.Log("정상 온도");
        }

        // 현재 온도 알려주는 텍스트 출력 : "현재 온도: 00도"
        Debug.Log($"현재 온도: {temperature}");
    }
}
