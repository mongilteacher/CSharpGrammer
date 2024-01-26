using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentTest : MonoBehaviour
{
    void Start()
    {
        Student student1 = new Student("전민성", 30, 32.5f);
        student1.Speak();

        Student student2 = new Student();
        student2.Name = "이성민";
        student2.Age = 24;
        student2.Speak();

        student1.HighFive(student2);

        // null: 사전적으로 존재하지 않는다, 비어있다.
        // 가장 빈번하게 오류를 일으키는 원인 중 하나
        Student student3 = null;
        // student3.Speak(); -> 버그

        student3 = student2;
        student3.Name = "김예은";
        Debug.Log(student2.Name); // "이성민" vs "김예은"
    }
}
