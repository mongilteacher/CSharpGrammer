using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People
{
    // 은닉화: 객체의 속성을 외부에서 직접 접근하지 못하도록 제한하는 개념
    // 캡슐화:
    // 데이터(속성)와 데이터를 처리하는 행위(메서드)를 하나로 묶는 것
    // 먼저 속성을 은닉화 하고 행위를 통해 속성을 접근/수정 하게 함으로서
    // 잘못된 접근이나 의도치 않는 값으로 변하는 보호 효과를 누린다.
    private string Name;
    private int Age;


    // 프로퍼티:
    // 속성이라는 뜻으로 변수의 값을 외부에서 접근할 수 있도록 하면서
    // 동시에 캡슐화를 지원하는 C#의 기능이다.
    // - get 접근자: 멤버 변수로부터 값을 읽어온다.
    // - set 접근자: 멤버 변수에 값을 할당한다.
    private float _height;
    public float Height
    {
        get // 프로퍼티 내부에 get만 지정하면 읽기 전용
        {
            return _height;
        }
        set // 프로퍼티 내부에 set만 지정하면 쓰기 전용
        {
            if (value < 0)
            {
                return;
            }

            _height = value;  // value 키워드는 set 접근자의 매개 변수
        }
    }

    private string _MBTI;
    public string MBTI
    {
        get { return _MBTI; }
        set
        {
            if(value.Length != 4)
            {
                return;
            }

            _MBTI = value;
        }
    }


   
    public People(string name, int age, float height, string mbti)
    {
        Name = name;
        Age = age;
        _height = height;
        _MBTI = mbti;
     }

    // Get/Set  -> 데이터(속성)를 외부에서 읽고/수정 시 무결성이 깨질 수 있으므로
    // 데이터는 메서드를 통해 읽고/수정하는 게 좋다.
    public int GetAge()  // Get000 -> 일반적으로 외부에서 객체의 데이터를 읽을 때 쓰는 메서드
    {
        // 가공 후  외부로 전달할 수도 있다.(윤석열 나이 vs 한국 나이)
        return Age;
    }


    public void SetAge(int age) // Set000 -> 일반적으로 외부에서 객체의 데이터를 수정할 때 쓰는 메서드
    {
        // 검증을 통해 유효한 값만 수정할 수 있다.
        if(age < 0)
        {
            Debug.Log("0살보다 작은 나이를 할당하려 한다.");
            return;
        }

        if(age < this.Age)
        {
            Debug.Log("새로 입력하는 나이는 이전 나이보다 커야 한다.");
            return;
        }

        Age = age;
    }

    public string GetName()
    {
        return Name;
    }

    // 속성(멤버 변수) 은닉화/캡슐화 문제점:
    // 속성을 많이 선언할수록 Get/Set과 같은 메소드가 많아지고, (귀찮다...)
    // 변수에 접근한다는 느낌이 아닌 메소드를 사용한다는 느낌이 커진다.

    // 위 문제점을 보완하기 위해..

    // 프로퍼티:
    // 속성이라는 뜻으로 변수의 값을 외부에서 접근할 수 있도록 하면서
    // 동시에 캡슐화를 지원하는 C#의 기능이다.
    // - get 접근자: 멤버 변수로부터 값을 읽어온다.
    // - set 접근자: 멤버 변수에 값을 할당한다.
}