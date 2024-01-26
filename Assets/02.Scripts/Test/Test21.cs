using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test21 : MonoBehaviour
{
    public int N = 3;

    void Start()
    {
        int end = 2 * N - 1;
        int center = end / 2 + 1;

        for(int i = 0; i < center; i++)
        {
            string str = "";

            for (int j = 1; j <= center; j++)
            {
                if (j < (center - i))
                {
                    str += "  ";
                }
                else
                {
                    str += "*";
                }
            }
            Debug.Log(str);
        }

        for (int i = center; i > 1; i--)
        {
            string str = "";
            for (int j = center; j > 0; j--)
            {
                if (j < i)
                {
                    str += "*";
                }
                else
                {
                    str += "  ";
                }
            }
            Debug.Log(str);
        }
    }


}
