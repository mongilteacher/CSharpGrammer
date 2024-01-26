using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스: 객체를 하나의 집합으로 묶는 단위, 틀
// 객체는 '만드는 과정'과 '사용하는 과정'이 필요한데
// 객체가 어떤 속성이 있고 어떤 기능(행위)를 하는지 설명하는 설계도

public class Student
{
    // 속성(멤버 변수)
    // 멤버 변수: 클래스에 소속된 변수
    // 같은 클래스에 소속되어 있는 함수는 이 변수를 조건 없이 사용 가능
    public string Name;
    public int Age;
    private float _weight;


    // 생성자: new 키워드를 이용해서 객체를 생성할 때 자동으로 호출되는 함수
    //   ㄴ 생성할 때 호출하는 함수
    //   ㄴ 반환 자료형을 안써주고, 클래스 이름과 동일하게 만든다.
    //   ㄴ 주로 객체 생성과 동시에 속성(멤버 변수)을 초기화할 때 사용한다.
    
    // 기본 생성자: 매개변수가 없는 생성자는 다른 생성자가 없을 경우 자동으로 생성된다.
    public Student() 
    {
        _weight = 50f;
    }

    public Student(string name, int age, float weight)
    {
        Name = name;
        Age = age;
        _weight = weight;
    }



    // 행동(멤버 함수)
    // 같은 클래스에 소속되어 있는 함수끼리는 조건 없이 호출 가능
    public void Speak()
    {
        Debug.Log($"안녕. 내 이름은 {Name}이고, 나이는 {Age} 살이야");
    }

    public void HighFive(Student otherStudent)
    {
        Debug.Log($"{Name}과 {otherStudent.Name}은 하이파이브를 했다!");
    }
}
