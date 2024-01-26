using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example03 : MonoBehaviour
{
    void Start()
    {
        // 변수의 특징(팁)
        // 1. 변수의 이름은 대,소문자를 구분한다.
        int age = 20;
        int Age = 30;
        Debug.Log(age);
        Debug.Log(Age);

        // 2. 변수의 이름은 숫자로 시작할 수 없다.
        // int 1student = 3;

        // 3. 변수의 이름은 의미있게 짓는다.

        // 4. 변수를 사용하기 전에 값을 미리 할당해야한다.
        // 초기화: 변수 선언과 동시에 값을 할당하는 것
        // 초기값: 처음 초기화할 때 저장하는 값
        // float height; -> 선언만 한 것
        float height = 185.2f;

        int monsterHealth;

        // 게임을 키면 언젠가
        monsterHealth = 100;

        //Debug.Log(testNumber);
    }

}
