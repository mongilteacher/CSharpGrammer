using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : MonoBehaviour
{
    public int Dice1 = 3;
    public int Dice2 = 3;
    public int Dice3 = 6;

    void Start()
    {
        int reward = 0;

        if((Dice1 == Dice2) && (Dice2 == Dice3) && (Dice1 == Dice3))
        {
            /// 같은 눈이 3개가 나오면
            /// 10,000원+(같은 눈)×1,000원의 상금을 받게 된다.
            /// 
            reward = 10000 + Dice1 * 1000;
        }
        else if(Dice1 == Dice2 || Dice2 == Dice3 || Dice1 == Dice3)
        {
            // 같은 눈이 2개만 나오는 경우에는
            // 1,000원+(같은 눈)×100원의 상금을 받게 된다.

            if (Dice1 == Dice2)
            {
                reward = 1000 + Dice1 * 100;
            }
            else if (Dice2 == Dice3)
            {
                reward = 1000 + Dice2 * 100;
            }
            else if (Dice1 == Dice3)
            {
                reward = 1000 + Dice3 * 100;
            }
        }
        else
        {
            // 모두 다른 눈이 나오는 경우에는
            // (그 중 가장 큰 눈)×100원의 상금을 받게 된다.
            if(Dice1 > Dice2 && Dice1 > Dice3)
            {
                // Dice1이 가장 크다.
            }
            else if (Dice2 > Dice1 && Dice2 > Dice3)
            {
                // Dice2이 가장 크다.
            }
            else
            {
                // Dice3이 가장 크다.
            }
        }

        Debug.Log(reward);
    }
}
