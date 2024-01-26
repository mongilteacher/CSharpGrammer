using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example11 : MonoBehaviour
{
    // 게임에서 캐릭터를 만들었을 때 각 캐릭터의 동작을 상수화해서 저장
    const int PlayerIdle   = 0;
    const int PlayerMove   = 1;
    const int PlayerAttack = 2;
    const int PlayerDeath  = 3;

    public int PlayerCurrentState = PlayerIdle;

    // 열거형(enum): 상수를 하나의 그룹으로 묶어서 관리하는 방법
    public enum PlayerStates
    {
        Idle,
        Move,
        Attack,
        Death,
    }
    public PlayerStates State = PlayerStates.Idle;

    void Start()
    {
        
    }
}
