using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public string Nickname;

    public void Watch()
    {
        Debug.Log($"{Nickname}: 와 보러가야겠다.");
    }
    
    public void PostPone()
    {
        Debug.Log($"{Nickname}: 나중에 봐야지....");
    }
}
