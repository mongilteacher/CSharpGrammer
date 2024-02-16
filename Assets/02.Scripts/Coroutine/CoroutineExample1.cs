using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample1 : MonoBehaviour
{
    // 코루틴: 유니티에서 비동기 작업을 수행하는 방법 중 하나
    void Start()
    {
        // 동기란: 어떤 작업을 수행할 때 그 작업을 처음부터 끝까지 멈추지 않고 다 수행하는것
        // -> 하나의 코드 실행이 완료되어야 다음 코드가 실행된다.
        // 김홍일.아이스크림사기(); // (20분 걸린다.)
        // 김홍일.수업진행();
        // 장점: 작업 순서를 명확하게 보장하고, 작업이 끝날 때까지 결과를 기다리는 것이 가능하다. 
        
        // 비동기란: 어떤 작을 수행할 때 그 작업이 완료되지 않더라도 다음 코드를 실행하는 방식
        // -> 즉, 작업 완료를 기다리지 않고 다음 코드를 실행하는 것
        // 장점: 작업이 오래 걸리는 경우 시간을 절약하고, 병렬적인 작업 처리가 가능하다.
        // 김홍일.아이스크림 사오라고 시키기.(이태환);
        // 김홍일.수업진행();
        
        // 코루틴: 유니티에서 비동기 작업을 수행하는 방법 중 하나
        StartCoroutine(BuyIceCream_Coroutine());
        Debug.Log("수업 진행중...");
    }

    // 코루틴의 특징:
    // 1. 비동기 실행이 가능하다.
    // 2. 세밀한 시간 제어가 가능하다. (시간: 대기, 조절, 일시 중지)
    
    private IEnumerator BuyIceCream_Coroutine()
    {
        Debug.Log("김홍일: 태환씨 아이스크림 사오세요.");
        
        // 5초가 걸린다고 가정
        yield return new WaitForSeconds(5);
        
        Debug.Log("이태환: 아이스크림 사왔습니다.");
    }
}
