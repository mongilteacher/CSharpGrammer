using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class RandomTest : MonoBehaviour
{
    void Start()
    {
        // UnityEngine.Random 클래스: 난수 생성과 관려있는 클래스
        // 난수: 정의된 범위 내에서 무작위로 추출된 수 (=랜덤값)

        UnityEngine.Random.InitState(13);
        Debug.Log(Random.Range(0, 100));
        //Debug.Log(UnityEngine.Random.Range(0f, 100f));
    }


}
