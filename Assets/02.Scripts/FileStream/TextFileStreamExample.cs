using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// 파일스트림
// 파일을 다룰 때 데이터가 움직이는 것을 흐름(stream)으로 비유한 것
// 파일을 다루기 위해서는 System.IO(Input/Output) 네임스페이스에 있는 FileStream 클래스 사용


public class TextFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // <파일 열기>
        // 매개변수
        // 1. 어떤 파일?       (파일의 경로)
        // 2. 어떻게 다룰꺼냐? (파일의 모드)
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: 파일이 없다면 새로 생성해주고, 있으면 덮어씌운다.

        // <파일 쓰기>
        // 텍스트 파일을 쓸때는 "StreamWriter" 클래스 사용
        StreamWriter sw = new StreamWriter(fs);
        try
        {
            sw.WriteLine("안녕하세요.");
            sw.WriteLine("제 이름은 이성민입니다..");
            // test.txt 파일 삭제
            sw.WriteLine("만나서 반가워요.");
        }
        catch (Exception e)
        {
            // 적절한 예외 처리 코드를 처리
        }
        finally
        {
            sw.Close(); // 파일을 다 쓰면 꼭 닫아줘야 한다.
        }
        

        // <파일 읽기>
        // 텍스트 파일을 읽을때는 "StreamReader" 클래스 사용
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open); // 다시 열기
        StreamReader sr = new StreamReader(fs);
        while(true)
        {
            string line = sr.ReadLine();
            if(line == null)
            {
                break;
            }

            Debug.Log(line);
        }
        sr.Close(); // 파일을 다 쓰면 꼭 닫아줘야 한다.
    }
}
