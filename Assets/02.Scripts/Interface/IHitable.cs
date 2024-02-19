using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 때리는 방법에 대한 약속
public interface IHitable
{
    void Hit(int damage);
}
