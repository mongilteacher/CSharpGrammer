using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoepleTest : MonoBehaviour
{
    void Start()
    {
        People people = new People("이성민", 25, 180.1f, "INFP");
        people.SetAge(26);
        people.SetAge(-3);


        people.Height = -10;         // 프로퍼티 set 접근자 사용
        Debug.Log(people.Height);    // 프로퍼티 get 접근자 사용


        people.MBTI = "AAA"; // 실습. MBTI에 대해서 프로퍼티를 적용해보세요.
        Debug.Log(people.MBTI);

        // people.Age = -3; // 무결성이 깨졌다!
        // 무결성이란 데이터의 정확성, 일관성, 유효성 
        Debug.Log(people.GetName());
        Debug.Log(people.GetAge());
    }
}
