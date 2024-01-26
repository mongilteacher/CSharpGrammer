using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test33 : MonoBehaviour
{
    public string InputString;
    // Start is called before the first frame update
    void Start()
    {
        string result = InputString;// 입력받은 문자열

        char space = ' ';  // 공백:띄어쓰기

        int spaceCount = 0;// 띄어쓰기 몇개인지 셀 값을 누적할 변수

        for (int i = 0; i < result.Length; i++) 
        // 만약에 i가0일때 result의 길이보다 작을 때 반복 i를 1씩 늘림
        {
            if (result[i] == ' ') //만약에 result[i]가 ' ' 공백일때
            {

                // 공백 카운트를 1씩 더한다
                spaceCount += 1;
            }
           
        }

        Debug.Log(spaceCount+1);
    }

 
}
