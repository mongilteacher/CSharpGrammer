using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // 변수 이름은 의미있게
    // 표기법: "파스칼케이스" 

    [Header("이름")]
    public string CharacterName = "시즈땡크";

    [Header("이동속도")]
    public int MoveSpeed = 140;

    [Header("공격력")]
    public float Damage = 107.00f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("이름: " + CharacterName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
