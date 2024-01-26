using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example07 : MonoBehaviour
{
    // 프로필
    // 멤버(변수) 접근 제한자: 멤버 변수의 접근을 제한하기 위해 사용하는 키워드
    // private: 클래스 내부에서만 접근 가능하다. (default)
    // public: 외부에서 자유롭게 접근 가능하다.
    public string name = "티모";
    public int age = 10;
    public float height = 148.3f;


    void Start()
    {
        Debug.Log("안녕하세요. C# 입니다.");
        Debug.Log("이름: " + name);
        Debug.Log("나이: " + age);
        Debug.Log("키: " + height);
    }

    void Update()
    {
        
    }
}
