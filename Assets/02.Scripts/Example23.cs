using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example23 : MonoBehaviour
{
    void Start()
    {
        string studentName1 = "김예은";
        string studentName2 = "이성민";
        string studentName3 = "전민성";
        // 만약 학생이 1000명이라면? 변수 1000개 선언?

        // 1. 배열이란
        // 같은 자료형의 데이터를 한 그룹으로 묶어서 사용하는 것
        // (연관된 데이터를 모아서 관리하기 위한 방법)

        /** 자료형[] 배열명 = new 자료형[크기] **/
        int size = 3;
        string[] studentNames = new string[size];

        // 인덱스: 각 요소(아이템)의 위치를 나타내는 번호다.
        // (0번부터 시작한다.)
        studentNames[0] = "김예은";
        studentNames[1] = "이성민";
        studentNames[2] = "전민성";

        // "김예은", "이성민", "전민성" 반복문 이용해서 출력하기
        for(int i = 0; i <= 2; i++)
        {
            Debug.Log(studentNames[i]);
        }
    }
}
