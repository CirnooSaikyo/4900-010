//using System.Diagnostics;
using UnityEngine;

public class Hello_World : MonoBehaviour
{

    int Counter = 0;
    float Timer = 0.0f;
    float waitTime = 1.0f;
    

    void Start()
    {
        Debug.Log("Hello, World!");
    }

    void Update()
    {
        Timer += Time.deltaTime;
        Debug.Log("Timer = " + Timer);
        if (Timer >= waitTime)
        {
            
            Debug.Log("Count = " + Counter);
            Timer -= waitTime;
            Counter++;
            
        }
    }
}
