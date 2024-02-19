using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IMoveable, IHitable
{
    public int health;
    
    public void Move()
    {
        Debug.Log("몬스터가 움직입니다.");
    }

    public void Hit(int damage)
    {
        health -= damage;
    }
    
}
