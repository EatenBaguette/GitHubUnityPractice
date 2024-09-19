using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public bool flag = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if(flag)
        {
            Debug.Log("Boolean flag is set.");
        }
        if(!flag)
        {
            Debug.Log("Boolean flag is not set.");
        }

        for(int i = 1; i < 11; i++)
        {
            Debug.LogFormat("The {0} power of 2 is {1}.", i, Mathf.Pow(2, i));
        }
    }
}
