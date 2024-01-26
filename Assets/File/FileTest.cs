using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileTest : MonoBehaviour
{
    void Start()
    {
        FileStream fs = new FileStream("/Users/USER/Desktop/test.txt", FileMode.Create);
    }

}