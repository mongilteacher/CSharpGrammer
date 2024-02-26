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
        a();
        a.Invoke();

        Action<string> b = Eat2;
        b.Invoke("김치 볶음밥");
        Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> c = null;
        // 반드시 반환값이 없고, 매개 변수의 개수를 0~16개인 메서드를 담을 수 있는 대리자

        // 매개변수를 최대 16개 까지 입력으로 받을 수 있다.
        // Action<string, int, float ...>
    }

    public void Eat()
    {
        Debug.Log("먹었다.");
    }

    public void Eat2(string foodName)
    {
        Debug.Log($"{foodName}을 먹었다.");
    }

}
