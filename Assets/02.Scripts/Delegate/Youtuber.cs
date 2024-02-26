using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Youtuber : MonoBehaviour
{
    // Event: 앞에서 배운 델리게이트를 좀 더 특수한 형태로 개조시킨 것
    // Event 특징
    // 1. 반환 타입과 매개변수가 없는 함수 형태를 의미하고
    // 2. public이어도 외부에서 Invoke할 수 없다.
    public UnityEvent VideoUploadEvent;

    private void Update()
    {
        // 마우스 버튼 누를 때마다 영상을 업로드 하는 상황을 가정
        if (Input.GetMouseButtonDown(0))
        {
            // 리스트에 영상을 추가하는 로직
            
            VideoUploadEvent.Invoke();
        }
    }
    

}
