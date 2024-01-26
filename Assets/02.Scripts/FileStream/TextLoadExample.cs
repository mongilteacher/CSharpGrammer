using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextLoadExample : MonoBehaviour
{
    void Start()
    {
        TextAsset textAsset = Resources.Load("student") as TextAsset;
        StringReader stringReader = new StringReader(textAsset.text);

        while(true)
        {
            string line = stringReader.ReadLine();
            if(line == null)
            {
                break;
            }

            string[] data = line.Split(',');

            string name = data[0];
            int age = int.Parse(data[1]);
            float birth = float.Parse(data[2]);

            Debug.Log($"{name}({age})의 생일: {birth}");
        }
    }
}
