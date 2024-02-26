using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DelegateExample3 : MonoBehaviour
{
    private delegate void ExDelegate();
    // ExDelegate 라는 대리자 타입은 "void 이름()" 형태의 메서드를 참조할 수 있다. 
    void Start()
    {
        // 델리게이트 멀티캐스트: 여러 개의 메서드를 담을수 있다는 뜻
        // 델리게이트 체인: 델리게이트가 참조하고 있는 여러 개의 메서드를 연결하여 연쇄적으로 호출하는 것
        ExDelegate morningRoutine = Wakeup;
        morningRoutine += EatWater;
        morningRoutine += Shower;   //  +=(덧셈 대입 연산자)를 이용해서 추가를 

        morningRoutine -= EatWater; // -=(뺄셈 대입 연산자)를 이용해서 빼기가 가능
        //morningRoutine -= Wakeup;
        //morningRoutine -= Shower;

        // 호출 방법 2가지
        // 1. () 가로 열고 닫고 문법
        // 2. Invoke()를 이용한 호출
        if (morningRoutine != null) // 널검사
        {
            //morningRoutine();
            morningRoutine.Invoke();
        }
        
        morningRoutine?.Invoke(); // 널이 아닐때만 호출해라!
    }

    private void Wakeup()
    { 
        Debug.Log("일어났다!");
    }

    private void EatWater()
    {
        Debug.Log("물마셨다!");
    }

    private void Shower()
    {
        Debug.Log("세수했다!");
    }
}

