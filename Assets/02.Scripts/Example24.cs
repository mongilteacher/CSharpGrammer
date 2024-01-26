using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example24 : MonoBehaviour
{
    void Start()
    {
        // 배열의 초기화: 배열의 선언과 동시에 값을 할당하는 것 -> 할당한 값 -> 초기값
        // 3가지 방법

        // 1. 첫 번째 방법
        int[] scores = new int[5] { 100, 99, 98, 97, 95 };

        // 2. 두 번째 방법: 첫 번쨰 방법에서 배열의 크기 생략
        int[] scores2 = new int[] { 100, 99, 98, 97, 95, 1 };

        // 3. 세 번째 방법: 두 번째 방법에서 new 연산자와 배열의 크기 모두 생략
        int[] scores3 = { 100, 99, 98, 50 };
    }
}
