using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example02 : MonoBehaviour
{
    void Start()
    {
        // 변수: 게임 내에서 필요한 데이터(이름, 나이)등을 저장하고 사용하기 위해 배정받은 공간
        // (단순하게 이름, 나이 같은 데이터 뿐만 아니라 화면에 보이는 이미지, 사운드 등 
        //  게임에 필요한 모든 데이터를 저장할 수 있다.)

        // 선언: 변수를 만드는 것(데이터를 저장할 공간 확보)
        // 1. 데이터를 활용하는 범위
        // 2. 데이터의 타입(숫자, 문자)
        // 3. 데이터를 부르는 이름 (변수명)
        // 필수: 2, 3
        // <데이터 타입> <변수명>

        // integer(정수)
        // 숫자 타입: 정수: -2, -1, 0, 1, 2 ... ,2312 와 같이 소수점이 없는 숫자
        int age = 20;

        // float (실수)
        // 숫자 타입: 부동소수점: -2.132, -1.34, 0.0, 123.23 와 같이 소수점이 있는 숫자
        float height = 185.2f;

        // string (문자열)
        // 문자열: 문자의 집합(문장)
        string name = "김홍일";

        // bool (논리)
        // 논리 타입: 참(true) 거짓(false)
        bool isMan = true;

        Debug.Log(age);
        Debug.Log(height);
        Debug.Log(name);
        Debug.Log(isMan);
    }

    void Update()
    {
        
    }
}
