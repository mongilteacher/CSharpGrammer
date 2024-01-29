using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExample : MonoBehaviour
{

    void Start()
    {
        // C#의 모든 자료형은 System.object를 상속받는다.
        // 어떤 데이터든 다룰 수 있는 타입
        // 참조형 (실제 데이터가 저장되어 있는 위치(주소값)을 참조한다.)
        
        // 박싱(Boxing)
        // 스택 메모리에 할당된 값 형식의 데이터를 힙에 할당하는 것
        // (object 형식에 값 형식의 데이터를 할당하면 박싱이 일어난다.)
        object intValue = 31;
        object floatValue = 150.1f;
        object boolValue = false;

        // 언박싱(Unboxing)
        // 힙에 저장된 값 형식의 데이터를 값 형식 변수에 할당하는 것
        // (object 형식의 데이터를 값 형식의 객체에 할당하면 언박싱이 일어난다.)
        int valueInt = (int)intValue;
        float valueFloat = (float)floatValue;
        bool valueBool = (bool)boolValue;


        intValue = (object)valueInt;
        floatValue = (object)valueFloat;
        boolValue = (object)valueBool;


        Debug.Log(intValue);
        Debug.Log(floatValue);
        Debug.Log(boolValue);
    }

    
}
