using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoepleTest : MonoBehaviour
{
    void Start()
    {
        People people = new People("이성민", 25);
        people.SetAge(26);
        people.SetAge(-3);

        // people.Age = -3; // 무결성이 깨졌다!
        // 무결성이란 데이터의 정확성, 일관성, 유효성 
        Debug.Log(people.GetName());
        Debug.Log(people.GetAge());
    }
}
