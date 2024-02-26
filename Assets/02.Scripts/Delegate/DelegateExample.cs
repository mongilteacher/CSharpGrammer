using UnityEngine;

// delegate(대리자): 메소드(함수)를 참조하고 있다가 대신 호출해주는 변수를 의미
// 지금까지는 어떤 메소드를 호출하려면 그 메소드를 가지고 있는 클래스 또는 객체를 찾아가서
// "." 연산자를 이용해 함수를 호출했다.
// 그러나 델리게이트는 누가 호출의 주체인지 알 필요없이 델리게이트 등록된 함수들을 대신해서 호출할 수 있다.

public class DelegateExample : MonoBehaviour
{
    private delegate void ExDelegate();
       //  [delegate] [반환타입] [델리게이트 이름] [(매개변수 목록)]
    void Start()
    {
        int number = 3;
        // [변수 타입] [변수명] = 초기값;
        ExDelegate myDelegate = Hello;

        myDelegate(); // 델리게이트를 이용한 대리 호출
        //Hello();    // 직접 호출
    }

    private void Hello()
    {
        Debug.Log("안녕하세요.");
    }
}
