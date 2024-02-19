using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IMoveable, IHitable
{
    public int health;
    
    public void Move()
    {
        Debug.Log("플레이어가 움직입니다.");
    }


    public void Hit(int damage)
    {
        if (Random.Range(0, 2) == 0)
        {
            health -= damage;
        }
    }
}
