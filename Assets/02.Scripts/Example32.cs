using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example32 : MonoBehaviour
{
    void Start()
    {
        // 가변 배열 (Jagged Array -> 들쭉날쭉한 배열)
        // 1차원의 크기를 다르게 설정할 수 있다.
        // 자료형[][] 배열명 = new 자료형[세로 크기][];

        // 전민성: 3, 9
        // 이윤석: 0, 3, 9
        // 정수빈: 1, 4, 3, 9
        
        // 1차원(가로)의 크기가 들쭉날쭉하므로
        // 2차원(세로) 크기만 먼저 선언하고,
        int[][] lines = new int[3][];
        // 1차원(가로)는 나중에 각각 따로 크기를 설정해준다.
        lines[0] = new int[] { 3, 9 };
        lines[1] = new int[] { 0, 3, 9 };
        lines[2] = new int[] { 1, 4, 3, 9 };

        // 사실 배열안에 배열이 있는 형태다.
    }
}
