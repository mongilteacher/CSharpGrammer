using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test20 : MonoBehaviour
{
    public int N;

    void Start()
    {
        /*for(int i = 0; i < N; ++i)
        {
            string star = "";

            for(int k = i; k < N; ++k)
            {
                star += "  ";
            }

            for(int k = N - i; k < N; ++k)
            {
                star += "*";
            }

            Debug.Log(star);
        }*/

        for (int i = 0; i < N; ++i)
        {
            string star = "";

            for(int j = 1; j <= N; ++j)
            {
                if (j < (N - i))
                {
                    star += "  " ;
                }
                else
                {
                    star += "*";
                }
            }

            Debug.Log(star);
        }

        string a = "Sprout";
        Debug.Log(a.Substring(2, 1));
        Debug.Log(a[2]);

        
    }

  
}
