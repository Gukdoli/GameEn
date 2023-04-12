using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prac06 : MonoBehaviour
{
    public float inch = 0;
    float cm;
    float cent(float inch)
    {
        float cm = inch * 2.54f;
        return cm;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        cm = cent(inch);
        Debug.Log(cm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
