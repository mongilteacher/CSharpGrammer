using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example22 : MonoBehaviour
{
    
    void Start()
    {
        // 숫자 1부터 10까지 출력하는 for 반복문
        for(int i = 1; i <= 10; i++)
        {
            if(i == 5)
            {
                continue; 
                // continue: 반복문에서 아래 코드들의 실행을 건너뛸때 사용
                // -> 반복을 취소하고 다시 다음 반복을 실행한다.
            }

            Debug.Log(i);
        }

        // 1부터 100까지 for 반복문과 continue를 이용해서 짝수만 출력하기

        // break: 반복문 블록안에서 실행을 중단하고 탈출할때 사용하고,
        // continue: 반복문의 반복을 한 번 취소하고 다음 반복을 실행할 때 사용한다.

    }
}