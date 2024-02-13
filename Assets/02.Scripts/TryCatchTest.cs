using System;
using UnityEngine;

public class TryCatchTest : MonoBehaviour
{
    // 예외(런타임 오류) 처리를 위해 try, catch, finally 같은 세 가지 키워드가 있다.
    // - try 블록({}):     혹시 모를 예외가 발생할 만한 구문을 묶어주고,
    // - catch 블록({}):   예외가 발생했을 때 처리해야 하는 구문을 묶어주며,
    // - finally 블록({}): 예외가 발생 또는 발생하지 않아도 무조건 처리될 구문을 묶어주는데 사용한다.
    void Start()
    {
        try // 시도해 보자!
        {
            // 혹시 모를 예외가 발생할 만한 구문을 묶어주고
            GameObject player = GameObject.Find("player");
            player.GetComponent<Rigidbody2D>();
        }
        catch (Exception e) // 예외를 잡는다.
        {
            // 예외가 발생했을 때 처리해야 하는 구문을 묶어주며
            Debug.Log("예외가 발생했습니다.");
            Debug.LogError($"예외: {e.Message}"); // Message: 예외에 대한 설명
        }
        finally
        {
            // 예외가 발생 또는 발생하지 않아도 무조건 처리될 구문을 묶어주는데 사용한다.
            Debug.Log("Finally");
        }
        
        // try-catch를 남용하면 프로그램 성능이 저하되므로 꼭 필요한 상황이 아니면 안쓰는게 좋다.
        // 예외가 예상되는 코드에는 다른 메커니즘(방어 코드: 조건문 사용)을 사용하는 것이 좋다.
        // 단점:
        // 1. 성능 저하 (스택 언롤링)
        // 2. 예외 객체 생성
        // 3. 로직의 복잡성 (유지보수 저하)
        
        
        // 보통 IO(입출력)에서 내가 제어할 수 없을때 쓴다.
        // - 파일 입출력
        // - 네트워크 입출력때 쓴다.
    }
    
}
