using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test30 : MonoBehaviour
{
    private void Start()
    {
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 나머지 값을 체크하기 위한 배열
        bool[] checks = new bool[42];

        // 1. 배열 A의 모든 값을 확인하고 싶다.
        for(int i = 0; i < A.Length; i++)
        {
            // 2. 각 요소의 값을 42로 나눈 나머지 값 확인
            //Debug.Log(A[i] % 42);
            checks[A[i] % 42] = true;
            // 42로 나눈 값의 나머지는 항상  0 ~ 41 범위
        }

        // 서로 다른 나머지가 몇 개 있는지 출력한다.
        int count = 0;
        // 3. checks 배열에서 true 개수를 구한다.
        foreach(bool check in checks)
        {
            if(check == true)
            {
                count++;
            }
        }

        Debug.Log(count);
    }
}
