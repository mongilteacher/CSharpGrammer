using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example38 : MonoBehaviour
{
    // 가변 길이 매개 변수
    // -> 매개 변수 개수가 유연하게 변한다.
    int Add(params int[] nums)
    {
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    }

    void Start()
    {
        Add(1);
        Add(1, 2);
        Add(1, 5, 2);
        Add(1, 123, 23, 2, 34);
        Add(1, 123, 23, 2, 3495, 33);
        Add(1, 123, 23, 2, 3495, 3123489);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
