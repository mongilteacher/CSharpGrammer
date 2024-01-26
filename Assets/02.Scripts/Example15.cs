using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example15 : MonoBehaviour
{
    void Start()
    {
        // 데이터의 형 변환
        // -> 변수에 담겨 있는 데이터를 다른 데이터 타입(자료형)의 변수에 옮겨 담는 것

        // 1. 정수 사이의 변환(sbyte, short, int, long 등)

        // 1-1. 옮겨 담는 자료형이 더 클때
        sbyte sbyteValue = 10;              // short 범위: -128 ~ 127
        int intValue = (int)sbyteValue;     // int 범위:   -21억 ~ 21억

        Debug.Log($"sbyteValue: {sbyteValue}");    // 10
        Debug.Log($"intValue: {intValue}");        // 10

        // 1-1. 옮겨 담는 자료형이 더 작고, 값의 범위를 넘어섰을때
        intValue = 130;
        sbyteValue = (sbyte)intValue;
        Debug.Log($"sbyteValue: {sbyteValue}");    // -126 (오버플로우 발생)
        Debug.Log($"intValue: {intValue}");


        // 2. 실수 사이의 변환(float, double, decimal)
        // 실수는 오버플로우가 존재하지 않고, 정밀도에 손상을 입는다.    
        double doubleValue = 3.1415926535897;    // 정밀도 15
        float floatValue = (float)doubleValue;   // 정밀도 7
        Debug.Log($"doubleValue: {doubleValue}");
        Debug.Log($"floatValue: {floatValue}");


        // 3. 실수를 정수로 형변환
        // 내림: 소수점 아래는 버리고 소수점 위의 값만 남긴다. (반올림 절대 아님)
        // 0.1f -> 0
        // 0.9f -> 0
        // 1.1f -> 1
        // 3.14151231232 -> 3
        float floatValue2 = 0.9f;
        int intValue2 = (int)floatValue2;
        Debug.Log($"intValue2: {intValue2}");  // 0

        // 4. 숫자를 문자열로 형변환
        // ToString() 메소드를 이용
        int intValue3 = 10;
        string stringValue3 = intValue3.ToString();
        Debug.Log($"stringValue3: {stringValue3}");


        // 5. 문자열을 숫자로 형변환
        // 5-1. Parse() 메소드를 이용
        string stringValue5 = "4354";
        int intValue5 = int.Parse(stringValue5);
        Debug.Log($"intValue5: {intValue5}");

        // 5-2. TryParse() 메소드 이용하기
        // -> 형 변환 성공 여부를 논리형으로 알려준다.
        string stringValue6 = "4354하하하하호호";
        int intValue6;
        bool isSuccess = int.TryParse(stringValue5, out intValue6);
        if(isSuccess )
        {
            Debug.Log("변환 결과: {isSuccess}");
        }
        else
        {
            Debug.Log("변환 실패");
        }
    }
}
