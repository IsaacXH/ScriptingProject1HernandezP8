using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }
}