using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BinaryFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // <파일 열기>
        // 매개변수
        // 1. 어떤 파일?       (파일의 경로)
        // 2. 어떻게 다룰꺼냐? (파일의 모드)
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: 파일이 없다면 새로 생성해주고, 있으면 덮어씌운다.
        // .dat: 데이터(data)의 약어로 사용자가 정의한 데이터가 들어있는 파일의 확장자

        // <파일 쓰기>
        // 바이너리 파일을 쓸때는 "BinaryWriter" 클래스 사용
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write("Hello");
        bw.Write(593);     
        bw.Close();

        // 장점: 컴퓨터는 데이터를 0과1 같은 바이너리 형태로 처리하므로
        // Binary를 사용하면 메모리를 좀 더 효율적으로 사용하고, 속도도 더 빠르다.

        // <파일 읽기>
        // 바이너리 파일을 읽을 때는 "BinaryReader" 클래스 사용
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open); // 다시 열기
        BinaryReader br = new BinaryReader(fs);
        Debug.Log(br.ReadString());
        Debug.Log(br.ReadInt32());

     
        br.Close();
    }
}
