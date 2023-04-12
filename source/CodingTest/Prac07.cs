using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prac07 : MonoBehaviour
{
    public float inch = 0;
    // Start is called before the first frame update
    void Start()
    {
        InchToCm inchTo = new InchToCm();
        inchTo.cent(inch);
        Debug.Log(inchTo.cm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
