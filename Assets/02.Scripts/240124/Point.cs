using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 구조체(struct)
// - 클래스와 유사한 구조를 가지고 있다.
// - 클래스처럼 속성(변수)과 메소드를 가질 수 있다.
// 클래스는 객체를 추상화하고 만드는데 목적이 있고,
// 구조체는 다양한 데이터를 하나로 묶는 것에 의미가 있다.
// 클래스는 참조 형식이고, 구조체는 값 형식이다.
public struct Point
{
    public int X;
    public int Y;
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
