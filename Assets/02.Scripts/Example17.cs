using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example17 : MonoBehaviour
{
    public string Id;
    public string Password;

    const string ID = "teemo";
    const string PASSWORD = "1234";

    void Start()
    {
        // 1. ID가 다르면 출력: "존재하지 않는 ID입니다."
        // 2. ID는 같으나 비밀번호가 다르면 출력: "비밀번호가 틀렸습니다."
        // 3. ID와 비밀번호가 모두 같으면 출력: "로그인 됐습니다."

        if(Id != ID) // 만약: ID가 다르면
        {
            Debug.Log("존재하지 않는 ID입니다.");
        }
        else     // ID 같다.
        {
            // 중첩 조건문: 조건문 안에 또 다른 조건문이 들어가 있는 형태
            // 3중 조건문이 되면 '내가 뭔가 잘못하고 있지 않을까?' 생각해보자.

            if (Password != PASSWORD)
            {
                Debug.Log("비밀번호가 틀렸습니다.");
            }
            else
            {
                Debug.Log("로그인 됐습니다.");
            }
        }


       if(Id == ID) 
        {
            if (Password != PASSWORD)
            {
                Debug.Log("비밀번호가 틀렸습니다.");
            }
            else
            {
                Debug.Log("로그인 됐습니다.");
            }
        }
       else
        {
            Debug.Log("존재하지 않는 ID입니다.");

        }

    }
}
