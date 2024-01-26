using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStudent
{
    // static(정적) -> 클래스의 객체가 아닌 클래스 자체에 소속
    // 클래스를 정의하고 객체를 생성하여 객체의 멤버(변수, 메소드)에 접근하던
    // 기존 방식과 다르게 객체를 생성하지 않고 클래스 자체에서 멤버를 사용할 수 있다.
    // 또 다른 이름은 '공유'다.
    private static int Number;  // 정적 변수

    public string Name;
    public int Age;

    public MyStudent(string name, int age)
    {
        this.Name = name;
        Age = age;

        // 클래스가 공유하는 정적 변수의 값을 수정한다.
        Number++;
    }

    // 메소드 반환 자료형 앞에 'static' 키워드 사용
    // 정적 메소드는 객체와 상관없이 클래스 이름으로 바로 호출할 수 있다.
    public static void Hello()
    {
        // 정적 메소드 내부에서는 멤버를 참조할 수 없다. (접근할 수 없다.)
        // (클래스에 속해있으므로 클래스의 객체/멤버와는 관련이 없다.)
        // Debug.Log($"안녕. 내 이름은 {Name}이야.");
        Debug.Log("Hello");
    }

    public static int GetNumber()
    {
        return Number;
    }
}
