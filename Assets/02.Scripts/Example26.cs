using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example26 : MonoBehaviour
{
    void Start()
    {
        string firstName = "전";
        string lastName = "민성";
        string displayName = string.Empty;  // 이름: 전민성

        // 문자열을 묶는 여러 가지 방법(3가지)
        // 1. 더하기(+) 연산자 사용
        displayName = "이름 : " + firstName + lastName;
        Debug.Log(displayName);

        // 2. string.Format 사용
        displayName = string.Format("이름: {0}{1}", firstName, lastName);
        Debug.Log(displayName);

        // 3. 문자열 보간법($) 사용
        displayName = $"이름 {firstName}{lastName}";
        Debug.Log(displayName);
    }


}
