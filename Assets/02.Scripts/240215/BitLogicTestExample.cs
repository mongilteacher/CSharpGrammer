using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitLogicTestExample : MonoBehaviour
{
    void Start()
    {
        // 비트 논리 연산자: 변수 내의 비트(bit)를 조작하는 연산자

        int a = 10; // 0000 1010 = 10
        int b = 6;  // 0000 0110 =  6
        
        // 0000 1010 = 10
        // 0000 0110 =  6
        // 논리곱(&): 두 비트가 모두 1일때만 1 
        // 0000 0010 =  2
        Debug.Log(a & b);  // 2
        
        
        // 0000 1010 = 10
        // 0000 0110 =  6
        // 논리합(|): 두 비트중 하나만 1이어도 1
        // 0000 1110 = 14
        Debug.Log(a | b);  // 14
        
        
        // 0000 1010 = 10
        // 0000 0110 =  6
        // 베타적 논리합(^): 두 비트가 달라야 1
        // 0000 1100 = 12
        Debug.Log(a ^ b); // 12
        
        
        // 0000 1010 = 10
        // 보수(~): 반대로
        // 1111 0101 = -11
        Debug.Log(~a);
    }

 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
