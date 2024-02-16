using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example40 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 조건(삼항) 연산자
        // -> 조건식을 사용해서 조건식의 참, 거짓 여부에 따라 다른 결과값을 대입
        // 조건식 ? 조건식이 참일때의 값 : 조건식이 거짓일때의 값
        
        int number = 4;
        // Q. nubmer가 짝수면 "짝수"라고 출력, 홀수면 "홀수"라고 출력
        Debug.Log(number % 2 == 0 ? "짝수" : "홀수");

        int playerHealth = 100;
        int monsterDamage = 127;
        
        // 공격을 당했다. 
        // Q. 공격 당한 이후 플레이어 체력이 0보다 작으면 0이되게 하고 싶다.
        playerHealth = playerHealth - monsterDamage;
        
        // A1. 조건문 이용 방식
        // A2. Math.Max 이용 방식
        // A3. 삼항연산자 이용 방식
        playerHealth = playerHealth > 0 ? playerHealth : 0;

    } 
   
}
