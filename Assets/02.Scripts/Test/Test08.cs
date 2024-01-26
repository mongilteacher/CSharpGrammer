using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test08 : MonoBehaviour
{
    public int Score;


    public void Start()
    {
        // A: 90 ~ 100
        // B: 80 ~ 89
        // C: 70 ~ 79
        // D: 60 ~ 69
        // F: 그 외
        if(90 <= Score && Score <= 100)
        {
            Debug.Log("A");
        }
        else if (80 <= Score && Score <= 89)
        {

        }
        else if (70 <= Score && Score <= 79)
        {

        }
        else if (60 <= Score && Score <= 69)
        {

        }
        else
        {
            Debug.Log("F");
        }

        // A: 90 ~ 100
        // B: 80 ~ 89
        // C: 70 ~ 79
        // D: 60 ~ 69
        // F: 그 외
        //Score /= 10;

        switch(Score)
        {
            case 10:
            case 9:
            {
                Debug.Log("A");
                break;
            }

            case 8:
            {
                Debug.Log("B");
                break;
            }

            default:
            {
                Debug.Log("F");
                break;
            }
        }

        switch(Score)
        {
            case >=90:
            {
                Debug.Log("A");
                break;
            }

            case >=80:
            {
                Debug.Log("B");
                break;
            }
        }
    }
}
