using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// C# 버전이 올라가면서 편의성을 위해 일일히 delegate를 지정하지 않는 버전인
// 제네릭(타입에 상관없는~) 대리자를 만들었다.
// - Action: 반환값이 없는(void)인 메서드를 담는 대리자
// - Func: 매개변수와 반환값이 있는 메서드를 담는 대리자
// - Predicate: bool 값을 반환하는 메서들를 담는 대리자
public class ActionExample : MonoBehaviour
{
    void Start()
    {
        // Action<T>
        // 입력: T 타입
        // 반환: 없음
        Action a = Eat;
        a = () =>  // "익명 함수"라고도 부른다.
        {
            Debug.Log("먹었다.");
        };
        a = delegate ()  // "익명 함수"라고도 부른다.
        {
            Debug.Log("먹었다.");
        };
        a();
        a.Invoke();

        Action<string> b = (foodName) =>
        {
            Debug.Log($"{foodName}을 먹었다.");
        };
        // 람다식은 접근자, 함수이름, 반환문(return)이 없다.
        // 코드를 더 가독성있게 만들거나 함수가 매개변수로 딱 한 번 쓰일떄 쓴다.
        
        
        b.Invoke("김치 볶음밥");
        Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> c = null;
        // 반드시 반환값이 없고, 매개 변수의 개수를 0~16개인 메서드를 담을 수 있는 대리자

        // 매개변수를 최대 16개 까지 입력으로 받을 수 있다.
        // Action<string, int, float ...>
        
        // 람다식이란 수학 함수를 하나의 식(코드 조각)으로 표현한 것
        // F(x) = x + 3
        // F(6) => 9
        // F() = 4
        // F(x, y) = x^2 + y^2
        // F(2, 3) => 13
        // F(string foodName) => Debug.Log($"{foodName}을 먹었다.")
        
        
    }

    public void Eat()
    {
        Debug.Log("먹었다.");
    }
    
}
