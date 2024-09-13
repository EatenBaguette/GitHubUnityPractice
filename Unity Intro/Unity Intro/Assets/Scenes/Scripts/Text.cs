using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public bool isSet = false;
    
    // Start is called before the first frame update
    void Start()
    {
        {
            if (isSet)
            {
                Debug.Log(message: "Hello, world!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
