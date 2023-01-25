using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndAwake : MonoBehaviour

{
    void Awake()
    {
        Debug.Log("Awake called.");
    }


    void Start()
    {
        Debug.Log("Start called.");
    }
}
