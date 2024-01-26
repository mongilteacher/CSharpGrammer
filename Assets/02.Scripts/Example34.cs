using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example34 : MonoBehaviour
{
    // 함수란 재사용을 목적으로 특정 작업을 수행하는 코드 블록
    // 장점 1: 의미 있는 작업(기능) 단위로 분리
    // 장점 2: 재사용 가능하다.
    // 장점 3: 반복되는 코드를 줄일 수 있다.

    /**
       // 반환 자료형이 없을 경우: void
      '반환 자료형' '함수 이름'('매개변수 목록')
       {
            // 실행할 코드들
            // return 반환 데이터
       }
    **/

    void Start()
    {
        Hello();

        for (int i = 0; i< 10; i++)
        {
            // 함수를 호출(사용)
            // 함수이름();
            Hello();
        }

        Hello();
    }

    void Hello()
    {
        Debug.Log("안녕하세요.");
    }

    void Update()
    {
        
    }
}
