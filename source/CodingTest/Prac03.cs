using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prac03 : MonoBehaviour
{
    public float inch = 0;
    // Start is called before the first frame update
    void Start()
    {
        float cm = 1.9f;
        float cent;

        cent = inch * 2.54f;
        Debug.Log(cent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
