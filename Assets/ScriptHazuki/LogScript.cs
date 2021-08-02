using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogScript : MonoBehaviour
{
    // Start is called before the first frame update
    int[] array = new int[3];

    void Start()
    {
        int i = 123;
        float f = 0.987f;
        Debug.Log($"int={i} float={f}");
        Debug.unityLogger.logEnabled = true;
        Debug.Log("Info 1");
        Debug.unityLogger.logEnabled = false;
        Debug.Log("Info 2");
        Debug.unityLogger.logEnabled = true;
        Debug.Log("Info 3");
        Debug.Log("log output");
        
    }
    

    public void Show()
    {
        array[0] = 2;
        Debug.Log(array[0]);
    }

}
