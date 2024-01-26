using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example20 : MonoBehaviour
{
    void Start()
    {
        //for(초기식; 조건식; 증감식)


        // 3-2. while 반복문
        // for 반복문과 다르게 괄호안에 '조건식'만 들어간다.
        // for와 마찬가지로 조건식이 참(true)일 동안만 아래 코드 블럭({})을 반복 실행한다.
        /**
          while(조건식)
          {
            // 조건식이 참인 경우 실행할 코드들
          }
        **/

        // 보통 초기화는 while 반복문 위에서 작성한다.
        int i = 0;

        

        while(3 > 1)
        {
            Debug.Log("안녕하세요. 제 이름은 티모입니다.");

            i++;
        }

        // 무한 루프
        // 정해진 회수 없이 무한하게 코드를 반복하면 프로그램이 뻗어버린다.
        // 자주하는 실수
        // 1. 증감식을 빼먹었다.
        // 2. 조건이 항상 true다.

        // for: 반복하고자 하는 순서나 조건이 명확할때
        // while: 반복하고자 하는 순서나 조건이 명확하지 않을때 -> (조건)유동적일때
    }


}
