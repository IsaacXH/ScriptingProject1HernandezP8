using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariblesAndFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    int myInt = 5;
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
