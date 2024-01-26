using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example13 : MonoBehaviour
{
    // bool논리 자료형
    // 참과 거짓을 저장하는 자료형
    // true(참), false(거짓)

    bool isDie = false;   // 죽었는가? -> 거짓
    bool hasItem = true;  // 아이템을 가지고 있는가? -> 참


    private void Start()
    {

        // 4. 비교(관계) 연산자
        // 양쪽 값(변수)을 비교해서 결과를 true(참) 또는 false(거짓)인지 판명해주는 연산자
        // 비교: 주어진 값(변수)들이 같은지/작은지/큰지/다른지 등 구분

        int num1 = 10;
        int num2 = 20;

        bool result1 = num1 == num2; // 같은지 판단
        Debug.Log(result1);

        bool result2 = num1 != num2; // 다른지 판단
        Debug.Log(result2);

        bool result3 = num1 > num2; // 왼쪽 값이 더 큰지 판단
        Debug.Log(result3);


        bool result4 = num1 >= num2; // 왼쪽 값이 더 크거나 같은지 판단
        Debug.Log(result4);

        int playerHealth = 100;
        int monsterDamage = 80;

        bool isDeath = playerHealth <= monsterDamage;
    }

}
