using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example28 : MonoBehaviour
{
    void Start()
    {
        // 1. 문자열 탐색
        string str = "Hello, World";

        // Q. 문자열 안에 "Wor" 문자열이 있는가?
        string test = "Wor";
        Debug.Log(str.Contains(test));

        // Q. 문자열 안에 'e'라는 문자가 몇번째 있는가?
        Debug.Log(str.IndexOf('e'));

        // Q. 문자열이 'He'로 시작하니?
        Debug.Log(str.StartsWith("He"));


        // 2. 문자열 변형
        string str2 = "  Hello  ";

        // 문자열을 모두 대문자로 출력하기
        Debug.Log(str2.ToUpper());
        str2 = str2.ToUpper();
        // 문자열을 모두 소문자로 출력하기
        Debug.Log(str2.ToLower());
        // 문자열의 앞,뒤 쪽에 있는 공백을 삭제
        Debug.Log(str2.Trim());

        Debug.Log(str2);


        // 3. 문자열 분할
        // 3-1. Split: 주어진 문자 혹은 문자열을 기준으로 분할
        string str3 = "김경희 정수빈 전민성 이성민 김예은";
        string[] names = str3.Split(" ");
        // names: [0]: "김경희", [1]: "정수빈", ... , [4]: "김예은"
        for(int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }    

        // Replace, SubString
    }
}
