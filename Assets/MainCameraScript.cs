using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public CounterScript counterScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counterScript.IncrementCounter();
        }
    }
}